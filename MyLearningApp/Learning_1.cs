// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*Объявите переменную, которая хранит массив, тип
элементов у которого string и поместите туда ссылку
на новый массив с типом элементов string,
размерностью в 5 элементов.
Далее, через оператор индексации,
проинициализируйте каждый элемент*/

string[] array = new string[5];
string[] array2 = array;

for (int i = 0; i < array.Length; i++)
{
    array[i] = "array" + i;
    Console.WriteLine(array2[i]);    
}

Console.WriteLine("________________________________________");
/*Напишите программу, которая выведет сумму всех
элементов массива.
*/
int[] numbers = new int[3];
numbers[0] = 1;
numbers[1] = 15;
numbers[2] = 2;

for (int i = 0; i < numbers.Length;i++)
{
    Console.WriteLine(numbers[i]); 
}

Console.WriteLine("________________________________________");
/*Напишите программу, которая выведет сумму всех
элементов массива.
*/
int[] numbers_2 = new int[3];
int sum;

numbers_2[0] = 1;
numbers_2[1] = 15;
numbers_2[2] = 2;

sum = numbers_2.Sum();
Console.WriteLine(sum);

Console.WriteLine("________________________________________");
/*Напишите программу, которая выведет
максимальное число в массиве.*/


int[] numbers_3 = new int[3];
int max;

numbers_3[0] = 1;
numbers_3[1] = 15;
numbers_3[2] = 2;

max = numbers_3.Max();
Console.WriteLine(max);

Console.WriteLine("________________________________________");
/*Пример 2-х мерного массива*/

int[,] map = new int[3, 3];
map[0, 0] = 1;
map[1, 0] = 2;
map[2, 0] = 3;
map[0, 1] = 1;
map[2, 1] = 3;
map[0, 2] = 1;
map[1, 2] = 2;
map[2, 2] = 3;
for(int x = 0; x < map.GetLength(0); x++)
{
    for(int y = 0;y < map.GetLength(1); y++)
    {
        Console.Write(map[x,y]);
    }
    Console.WriteLine();
}

Console.WriteLine("________________________________________");
/*Массив массивов/кортеж */

string[][] street = new string[][]
    {
    new string[] { "Mary", "Thomas" },
    new string[] { "Carl" },
    new string[] { "Bob", "Jhonatan", "Alex"}
    };

for(int i = 0; i < street.Length; i++)
{
    Console.WriteLine($"Дом {i + 1}:");
    for(int p = 0; p < street[i].Length; p++)
    {
        Console.WriteLine(street[i][p]);
    }
}

Console.WriteLine("________________________________________");
/*
//Пример
int     countStr;
 //       checklengthChar;
string  textInput,
        textNotification = "Введите текст",
        character = "Введите искомый символ",
        textError = "Символ не введён!",
        checkEnterChar;
Char    ch;


Console.WriteLine(textNotification);
textInput = Console.ReadLine();

Console.WriteLine(character);
//ch = Console.ReadKey(false).KeyChar;
//ch = Console.ReadLine()[0];
checkEnterChar = Console.ReadLine();
//checklengthChar = checkEnterChar.Length;

//if(ch == '\0')
//if(checklengthChar < 1)
if(string.IsNullOrEmpty(checkEnterChar))
{
    Console.WriteLine(textError);
    return;
}

ch = checkEnterChar[0];

countStr = GetSymbolCount(textInput, ch);
Console.WriteLine($"В ведённом тексте: {textInput}, символ {ch} повторяется {countStr} раз(a)");

static int GetSymbolCount(string text, char symbol)
{
    int count = 0;
    for(int i = 0; i < text.Length; i++)
    {
        if(text[i] == symbol)
        {
            count++;
        }
    }
    return count;
}
*/

/*
TankAction TankAction = new TankAction();
Tank Tank = new Tank();

TankAction.tankMethod();
*/

//Tank_2 Tank_2 = new Tank_2(10,0);
//Console.WriteLine(Tank_2.GetPositionX());

/*
Gun gun = new Gun(new List<int> {1,2,5});
//gun.Reload(new List<int> {1,2,5});
//gun.Bullets[0] = "10"; 
gun.Shot();
gun.Reload();
*/

/*
Console.WriteLine("Warning!", ConsoleColor.Yellow);
Console.WriteLine("Error!", ConsoleColor.Red);

WriteColoredMessage("Warning!", ConsoleColor.Red);
static void WriteColoredMessage(string message, ConsoleColor color)
{
    ConsoleColor oldColor = Console.ForegroundColor;
    Console.ForegroundColor = color;

    Console.WriteLine(message);
    Console.ForegroundColor = oldColor;
}
*/

// Warrior Warrior = new Warrior(100, 110);
// Knight  Knight = new Knight(150, 200);
// Barbarian Barbarian = new Barbarian(198,100, 15);
// Warrior.Health = 105;
// Warrior.TakeDamage(15);
// Knight.TakeDamage(20);
// Barbarian.Waaaagh();


// Gun gun = new Gun();
// Player player1 = new Player(250),
//        player2 = new Player(200);
// Battle Battle = new Battle(gun, new Player[] { player1, player2 });
// //player1.
// gun.Fire(player1);
// Battle.Simulate();


// Gun gun = new Gun();
// Player player1 = new Player();
// gun.Fire(player1);
// gun = new Bow();
// gun.Fire(player1);
// gun.Fire(player1);
// Battle battle = new Battle(new Pistol(), new Player[] { player1 });
// battle.Simulate();


// A a = new C();
// a.Do(); //1

// a = new B();
// a.Do(); //2


// Gun gun = new Gun();
// Player player = new Player();
// player.PickUp(gun);


// int         balance           = 0;
// PaymentType payment           = PaymentType.Coins;
// Boolean     bol               = true;
// string      command           = "";
// int[]       coinsQuantity     = { 0, 0, 0, 0}, //1, 2, 5, 10
//             coinsValues       = { 1, 2, 5, 10},
//             prices            = { 70, 60 },
//             availableQuantity = { 5, 2 };
// string[]    names             = { "Шоколадка", "Газировка"};


//Пример_1 класса VendingMachine

// while (bol)
// {
//     //Console.Clear();
//     // try
//     // {
//     //     Console.Clear();
//     // }
//     // catch (IOException)
//     // {
//     //     Console.WriteLine("Не удалось очистить консоль.");
//     // }

//     Console.WriteLine($"Баланс {balance}");
//     Console.WriteLine("Введите команду:");
//     command = Console.ReadLine();
//     if(command == "AddMoney")
//     {
//         bol = false;
//     }
//     else if(command == "GetChange")
//     {
//         bol = false;
//     }
//     else if (command.StartsWith("BuyGood"))
//     {
//         //Разбиение строки на единицы данных

//         string[] rawData = command.Substring("BuyGood ".Length).Split(' ');

//         //Сопоставление этих данных с переменными (и их типами)
//         if(rawData.Length != 2)
//         {
//             Console.WriteLine("Неправильные аргументы команды");
//             break;
//         }

//         int id = Convert.ToInt32(rawData[0]);
//         int count = Convert.ToInt32(rawData[1]);

//         //Проверка корректности этих данных
//         //на основе текущего состояния модели.
//         if(id < 0 || id >= names.Length)
//         {
//             Console.WriteLine("Такого товара нет");
//             break;
//         }

//         if(count < 0 || count > availableQuantity[id])
//         {
//             Console.WriteLine("Нет такого количества");
//             break;
//         }

//         //Выполнение
//         if(balance >= prices[id] * count)
//         {
//             balance -= prices[id] * count;
//             availableQuantity[id] -= count; 
//         }

//         bol = false;
//     }
//     else
//     {
//         Console.WriteLine("Команда неопределена");
//     }

//     //Console.ReadLine();
// }

// if(command == "AddMoney")
// {
//     switch (payment)
//     {
//         case PaymentType.Coins:
//         for(int i = 0; i < coinsValues.Length; i++)
//         {
//             int count = 0;
//             Console.WriteLine($"Сколько монет номиналом {coinsValues[i]} вы хотите внести?");            

//             while(!int.TryParse(Console.ReadLine(), out count))
//             {
//                 Console.WriteLine("Вы ввели не число!");
//             }
            
//             coinsQuantity[i] += count;
//             balance += count * coinsValues[i];
//         }
//         break;

//         case PaymentType.Card:
//         int balanceDelta = 0;
//         Console.WriteLine("Сколько снять свашей карты?");        
        
//         while(!int.TryParse(Console.ReadLine(),out balanceDelta))
//         {
//             Console.WriteLine("Вы ввелине число!");
//         }

//         balance += balanceDelta;
//         Console.WriteLine("Баланс успешно пополнен");
//         break;

//         default:
//         break;  
//     }
// }


// enum PaymentType
// {
//     Coins,
//     Card
// }
//__________________________________________________________________________


////Пример_2 оптимизированный класса VendingMachine
// Boolean Enter = true;

// while (Enter)
// {
//     Console.WriteLine($"Баланс {VendingMachine.balance}");
//     //VendingMachine.coinsQuantity = new int[] { 0, 0, 0, 0 };
//     string command = VendingMachine.ReadCommand();
//     VendingMachine.ExecuteCommand(command);
//     Enter = Boolean.Parse(Console.ReadLine()); 
// }


// class VendingMachine
// {
//     public static int           balance           = 0;
//     public static int[]         coinsQuantity     = { 0, 0, 0, 0}; //1, 2, 5, 10
//     public static int[]         coinsValues       = { 1, 2, 5, 10};
//     public static string[]      names             = { "Шоколадка", "Газировка" };
//     public static int[]         prices            = { 70, 60 };
//     public static int[]         availableQuantity = { 5, 2};
//     public static PaymentType   payment           = PaymentType.Card;
//     public static string        command           = "";    
//     public static int           id                = 0,
//                                 count             = 0;

//     public static int ReadInt()
//     {
//         int result = 0;
//         while (!int.TryParse(Console.ReadLine(), out result))
//         {
//             Console.WriteLine("Вы ввели не число!");
//         }
//         return result;
//     }

//     public static bool MapParameter(string[] rawParams, out int containter, BuyGoodParameter parameter)
//     {
//         int index = (int)parameter;
//         string name = Enum.GetName(typeof(BuyGoodParameter), parameter);

//         if (!int.TryParse(rawParams[index], out containter))
//         {
//             Console.WriteLine($"Ошибка в параметре {name}, он должен быть числом");
//             return false;
//         }
//         return true;
//     }

//     public static int GetTotalPrice(int price, int count)
//     {
//         return price * count;
//     }

//     public static bool Exist(int id)
//     {
//         return id > 0 && id < names.Length;
//     }
    
//     public static void ValidateId(int id)
//     {
//         if (!Exist(id))
//         {
//             throw new ArgumentOutOfRangeException("id");
//         }
//     }

//     public static string GetName(int id)
//     {
//         ValidateId(id);
//         return names[id];
//     }


//     public static int GetPrice(int id)
//     {
//         ValidateId(id);
//         return prices[id];
//     }

//     public static int GetAvailableQuantity(int id)
//     {
//         ValidateId(id);
//         return availableQuantity[id];
//     }

//     public static bool IsAvailableInQuantity(int id, int count)
//     {
//         return count < 0 || count > GetAvailableQuantity(id);
//     }

//     public static string ReadCommand()
//     {
//         Console.WriteLine($"Баланс {balance}");
//         Console.WriteLine("Введите команду:");
//         return Console.ReadLine();
//     }


//     public static void ExecuteCommand(string command)
//     {
//         if(command == "AddMoney")
//         {
//             switch (payment)
//             {
//                 case PaymentType.Coins:
//                     for(int i = 0; i < coinsValues.Length; i++)
//                     {
//                         Console.WriteLine($"Сколько монет номиналом {coinsValues[i]} вы хотите внести?");
//                         int count = ReadInt();                        
//                         coinsQuantity[i] += count;
//                         balance +=  count * coinsValues[i];
//                     }
//                 break;

//                 case PaymentType.Card:
//                     Console.WriteLine("Сколько снять с вашей карты?");
//                     int balanceDelta = ReadInt();
//                     balance += balanceDelta;
//                     Console.WriteLine("Баланс успешно пополнен");
//                 break;

//                 default:
//                 break;
//             }
//         }
//         else if(command == "GetChange")
//         {
//             balance = 0;
//         }
//         else if(command.StartsWith("BuyGood"))
//         {
//             //Разбиение строки на единицы данных
//             string[] rawData = command.Substring("BuyGood ".Length).Split(' ');
//             // //Сопоставление этих данных с переменными (и их типами)
//             if(rawData.Length != 2)
//             {
//                 Console.WriteLine("Неправильные аргументы команды");
//                 return;
//             }

//             if(!MapParameter(rawData, out id, BuyGoodParameter.Id))
//             {
//                 return;
//             }

//             if (!MapParameter(rawData, out count, BuyGoodParameter.Count))
//             {
//                 return;
//             }  

//             int totalPrice = GetTotalPrice(prices[id], count);

//             if (!Exist(id))
//             {
//                 Console.WriteLine("Такого товара нет");
//                 return;
//             }

//             if (IsAvailableInQuantity(id, count))
//             {
//                 Console.WriteLine("Нет такого количества");
//                 return;
//             }

//             //Выполнение
//             if(balance >= totalPrice)
//             {
//                 balance -= totalPrice;
//                 availableQuantity[id] -= count;
//             }
//         }
//         else
//         {
//             Console.WriteLine("Команда не определена");
//         }
//     }

//     public enum PaymentType
//     {
//         Coins,
//         Card
//     }
//     public enum BuyGoodParameter    
//     {
//         Id = 0,
//         Count = 1
//     }
// }
//__________________________________________________________________________

// WendingMachine machine = new WendingMachine(balance: 1000, goods: new Good[]
//                                            {new Good("Шоколадка",price: 70, count: 5),
//                                             new Good("Газировка",price: 60, count: 2)});

// ICommandInput input = new ConsoleCommandInput(new Router(machine));

// while (true)
// {
//     Console.Clear();
//     Console.WriteLine($"Баланс {machine.Balance}");
//     var command = input.GetCommand();

//     if (command == null)
//     {
//         Console.WriteLine("Команда не распознана");
//     }
//     else
//     {
//         command.Execute();
//     }
    
//     Console.ReadKey();
// }



// private static Dictionary<int, int> _fibonacciResults = new Dictionary<int,int>();

// static int FibonacciMemoization(int n)
// {
//     if(_fibonacciResults.TryGetValue(n, out int value))
//     {
//         return value;
//     }
//     else
//     {
//         if (n < 3) 
//             _fibonacciResults.Add(n,1);
//         else
//         {
//             _fibonacciResults.Add(n, FibonacciMemoization(n - 1) + FibonacciMemoization(n - 2));
//         }
//     }
//     return _fibonacciResults[n];
// }



static int GetChangeSimple(int[] values, int change)
{
    int count = 0;
    foreach(int value in values.Distinct().OrderByDescending(x => x))
    {
        count += change / value;
        change = change % value;

        if (change == 0) 
            return count;
    }

    return 0;
}

int[] values = {1, 5, 10, 15, 20};
int change = 50;

//Console.WriteLine(GetChangeSimple(values, change));


static int GetChange(int[] values, int change)
{
    int minCoins = change;
    if (values.Contains(minCoins))
    {
        return 1;
    }
    else
    {
        foreach (var value in values.Where(x => x <= change))
        {
            int numCoins = 1 + GetChange(values, change - value);
            if(numCoins < minCoins)
            {
                minCoins = numCoins;
            }
        }
        return minCoins;
    }
}

//Console.WriteLine(GetChange(values, change));

//Оптимизация метода GetChange через мемоизацию
static int GetChangeMemoization(int[] values, int change, int[] getChangeResults)
{
    int minCoins = change;
    if (values.Contains(minCoins))
    {
        getChangeResults[change] = 1;
        return 1;
    }
    else if (getChangeResults[change] != 0)
    {
        return getChangeResults[change];
    }
    else
    {
        foreach (var value in values.Where(x => x <= change))
        {
            int numCoins = 1 + GetChangeMemoization(values, change - value);//, getChangeResults);
            if (numCoins < minCoins)
            {
                minCoins = numCoins;
                getChangeResults[change] = minCoins;
            }
        }
    }
    return minCoins;
}

Console.WriteLine(GetChangeMemoization(values, change));







