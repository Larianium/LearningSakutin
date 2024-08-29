using System.Reflection;
using System.Reflection.Metadata;

class WendingMachine
{
    private Good[] _goods;
    public int Balance { get; private set; }

    public WendingMachine(int balance, params Good[] goods)
    {
        _goods = goods;
        Balance = balance;
    }

    public void AddBalance(int delta)
    {
        if (delta < 0) 
            throw new ArgumentOutOfRangeException("delta");

        Balance += delta;
    }
    public void DiscardBalance(int delta)
    {
        if (delta < 0 || Balance > delta)
            throw new ArgumentOutOfRangeException("delta");

        Balance -= delta;
    }
    public bool IsOrderPossible(IOrder order)
    {
        return order.IsAvailable && order.GetTotalPrice() <= Balance;
    }
    public bool TryProcessOrder(PayableOrder order)
    {
        if (IsOrderPossible(order))
        {
            Balance -= order.GetTotalPrice();
            order.Ship();

            return true;
        }
        else
        {
            return false;
        }
    }
    public bool IsContains(int id)
    {
        return id >= 0 && id < _goods.Length;
    }
    public Good GetFromId(int id)
    {
        if (!IsContains(id)) 
            throw new ArgumentOutOfRangeException("id");

        return _goods[id];
    }
}


class Good
{
    public Good(string name, int price, int count)
    {
        Name = name;
        Price = price;
        Count = count;  
    }
    public string Name { get; private set; }
    public int Price { get; private set; }
    public int Count { get; set; }
}


// public abstract class SinglePositionOrder : IOrder
// {
//     public abstract void GetTotalPrice();

// }

interface ICommandInput
{
    ICommand GetCommand();
}

interface ICommand
{
    void Execute();
}

class ConsoleCommandInput : ICommandInput
{
    private Router _router;
    public ConsoleCommandInput(Router router)
    {
        _router = router;
    }
    public ICommand GetCommand()
    {
        string rawCommand = Console.ReadLine();
        Request request = ParseString(rawCommand);

        return _router.CreateCommand(request);
    }
    private Request ParseString(string input) 
    {
        string[] terms = input.Split(' ');
        int[] values = new int[0];
        if (terms.Length > 1)
        {
            values = new int[terms.Length - 1];
            for(int i = 1; i < terms.Length; i++)
            {
                values[i-1] = Convert.ToInt32(terms[i]);
            }
        }

        return new Request(terms[0], values);
    }
}

class Request
{
    public string Command { get; set; }
    public int[] Values { get; set; }

    public Request(string command, int[] values)
    {
        Command = command;
        Values = values;
    }
    public bool IsIncorectValuesCount(int correct)
    {
        return correct != Values.Length;
    }

    public bool TryGetValue(string name, out int value)
    {
    }
}

//Данную часть кода потребуется раскомментить после отработки 
class Router
{
    private WendingMachine _machine;
    private RouterState _state;
    private readonly Type _commandBaseType = typeof(ICommand);
    private Dictionary<Type, object> _dependecies;
    public Router(WendingMachine machine)
    {
        _machine = machine;
        _state = new DefaultState(this);

        _dependecies = new Dictionary<Type, object>()
        {
            { typeof(WendingMachine), _machine},
            { typeof(Router), this }
        };
    }
    public ICommand CreateCommand(Request request)
    {
        var commandType = GetCommandTypeByName(request.Command);

        if (commandType != null)
        {
            var instance = CreateInstance(commandType, request);
            return instance;
        }
        else
        {
            return null;
        }

        switch (request.Command)
        {
            case "AddMoney":
                if (request.IsIncorectValuesCount(1))
                    return null;

                return new AddMoney(_machine, request.Values[0]);
            case "GetChange":
                if (request.IsIncorectValuesCount(0))
                    return null;

                return new GetChange(_machine);
            case "BuyGood":
                if (request.IsIncorectValuesCount(2))
                    return null;
                //return new BuyGood(_machine, _state.MakeOrder(request));
                if (_state is DefaultState)
                    return new BuyGood(_machine, _state.MakeOrder(request) as PayableOrder);

                return null;
            case "ShowCommands":
                if (request.IsIncorectValuesCount(0))
                    return null;

                return new ShowCommands("AddMoney", "GetChange",
                                        "BuyGood", "ShowCommands");
            case "Login":
                if (request.IsIncorectValuesCount(0))
                    return null;

                return new Login(this);
            default:
                return null;
        }
    }
    public void Login() //public
    {
        _state = new AdminState(this);
    }
    public void Logout() //public
    {
        _state = new DefaultState(this);
    }

    public IEnumerable<string> GetCommands() //public
    {
        return GetCommandsTypes()
                //.Select(type => type.Name);
                .SelectMany(type => type.GetCustomAttributes<CommandAttribute>())
                .Select(attribute => attribute.CommandName);
    }

    private object[] ResolveDependenciesAndMerge(ConstructorInfo constructor, Request request) //private
    {
        List<object> args = new List<object>();

        Queue<int> requestArgs = new Queue<int>(request.Values);

        foreach (var parameter in constructor.GetParameters())
        {
            if (_dependecies.TryGetValue(parameter.Parameter Type, out object value))
            {
                args.Add(value);
            }
            else
            {
                //if (requestArgs.Count == 0)
                //    return null;
                //args.Add(requestArgs.Dequeue());

                if(request.TryGetValue(parameter.Name, out int arg))
                {
                    args.Add(arg);
                }
                else
                {
                    return null;
                }
            }
        }
        if (args.Count == constructor.GetParameters().Length)
        {
            return args.ToArray();
        }
        else
        {
            return null;
        }
    }

    private IEnumerable<Type> GetCommandsTypes() //private
    {
        return AppDomain
                .CurrentDomain
                .GetAssemblies()
                .SelectMany(assembly =>
                assembly.GetTypes())
                .Where(type =>
                _commandBaseType.IsAssignableFrom(type))
                .Where(type => IsRealClass(type));
    }

    private Type GetCommandTypeByName(string name) //private
    {
        return GetCommandsTypes()
                //.Where(type => type.Name == name)
                //.FirstOrDefault();
                .Where(type => type.GetCustomAttributes<CommandAttribute>()
                .Any(attribute => attribute.CommandName == name))
                .FirstOrDefault();
    }

    bool IsRealClass(Type testType) //private
    {
        return testType.IsAbstract == false
                && testType.IsGenericTypeDefinition == false
                && testType.IsInterface == false;
    }


    ICommand CreateInstance(Type type, Request request) //private
    {
        ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.Instance | BindingFlags.Public);
        foreach (var ctor in constructors)
        {
            var args = ResolveDependeciesAndMerge(ctor, request);
            if (args != null)
            {
                return (ICommand)ctor.Invoke(args);
            }
        }
        return null;
    }
    abstract class RouterState
    {

        protected readonly Router Router;
        public RouterState(Router router)
        {
            Router = router;
        }

        public abstract IOrder
        MakeOrder(Request request);
    }
    class DefaultState : RouterState
    {
        public DefaultState(Router router) : base(router)
        {

        }
        public override IOrder MakeOrder(Request request)
        {
            return new PayableOrder(Router._machine.GetFromId(request.Values[0]), request.Values[1]);
        }
    }
    class AdminState : RouterState
    {
        public AdminState(Router router) : base(router)
        {

        }
        public override IOrder MakeOrder(Request request)
        {
            return new FreeOrder(Router._machine.GetFromId(request.Values[0]), request.Values[1]);
        }
    }
}

[Command("AddMoney")]
class AddMoney : ICommand
{
    private WendingMachine _machine;
    private int _money;
    public AddMoney(WendingMachine machine, int money)
    {
        _machine = machine;
        _money = money;
    }
    public void Execute()
    {
        _machine.AddBalance(_money);
    }
}

class BuyGood : ICommand
{
    private WendingMachine _machine;
    //private IOrder         _order;
    private PayableOrder   _payableOrder;
    public BuyGood(WendingMachine machine, PayableOrder payableOrder) // IOrder order)
    {
        _machine = machine;
        //_order = order;
        _payableOrder = payableOrder;
    }
    public void Execute()
    {
        _machine.TryProcessOrder(_payableOrder);
    }
}

class GetChange : ICommand
{
    private WendingMachine _machine;
    public GetChange(WendingMachine machine)
    {
        _machine = machine;
    }
    public void Execute()
    {
        _machine.DiscardBalance(_machine.Balance);
    }
}

class Login : ICommand
{
    private Router _router;
    public Login(Router router)
    {
        _router = router;
    }
    public void Execute()
    {
        _router.Login();
    }
}

//class ShowCommands : ICommand
//{
//    private string[] _commands;
//    public ShowCommands(params string[] commands)
//    {
//        _commands = commands;
//    }
//    public void Execute()
//    {
//        foreach (string command in _commands)
//        {
//            Console.WriteLine(command);
//        }
//    }
//}

class ShowCommands : ICommand
{
    private Router _router;
    public ShowCommands(Router router)
    {
        _router = router;
    }
    public void Execute()
    {
        foreach (var command in _router.GetCommands())
        {
            Console.WriteLine(command);
        }
    }
}


// class Order : IOrder
// {
//     private Good _good;
//     private int _count;
//     public Order(Good good, int count)
//     {
//         if (count < 0) 
//             throw new ArgumentOutOfRangeException();

//         _good = good;
//         _count = count;
//     }
//     public bool IsAvailable 
//     {    
//         get
//         {
//             return _count <= _good.Count;
//         }
//     }
//     public int GetTotalPrice()
//     {
//         return _good.Price * _count;
//     }

//     public void Ship()
//     {
//         _good.Count -= _count;
//     }
// }

// class FreeOrder : IOrder
// {
//     private Good _good;
//     private int _count;
//     public FreeOrder(Good good, int count)
//     {
//         if (count < 0) 
//             throw new ArgumentOutOfRangeException();

//         _good = good;
//         _count = count;
//     }
//     public bool IsAvailable
//     {
//         get
//         {
//             return _count <= _good.Count;
//         }
//     }
//     public int GetTotalPrice()
//     {
//         return 0;
//     }
//     public void Ship()
//     {
//         _good.Count -= _count;
//     }
// }

interface IOrder
{
    bool IsAvailable { get; }
    abstract int GetTotalPrice(); // Попробовать убрать abstract
    void Ship();
}

abstract class Order : IOrder
{
    protected readonly Good Good;
    protected readonly int Count;
    public Order(Good good, int count)
    {
        if (count < 0) 
            throw new ArgumentOutOfRangeException();

        Good = good;
        Count = count;
    }
    public bool IsAvailable 
    {
        get
        {
            return Count<= Good.Count;
        }
    }
    public abstract int GetTotalPrice();
    public void Ship()
    {
        Good.Count -= Count;
    }
}
class PayableOrder : Order
{
    public PayableOrder(Good good, int count) : base(good, count)
    {

    }
    public override int GetTotalPrice()
    {
        return Good.Price * Count;
    }
}
class FreeOrder : Order
{
    public FreeOrder(Good good, int count) : base(good, count)
    {
        
    }
    public override int GetTotalPrice()
    {
        return 0;
    }
}

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
class CommandAttribute : Attribute
{
    public string CommandName;
    public CommandAttribute(string
    commandName)
    {
        CommandName = commandName;
    }
}




