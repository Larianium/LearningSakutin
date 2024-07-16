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


int balance = 0;
int[] coinsQuantity = { 0, 0, 0, 0}; //1, 2, 5, 10



int[] coinsValues = { 1, 2, 5, 10};
PaymentType payment = PaymentType.Coins;
string[] names = { "Шоколадка", "Газировка"
};
int[] prices = { 70, 60 };
int[] availableQuantity = { 5, 2 };

string command = "";
while (true)
{
    //Console.Clear();
    // try
    // {
    //     Console.Clear();
    // }
    // catch (IOException)
    // {
    //     Console.WriteLine("Не удалось очистить консоль.");
    // }

    Console.WriteLine($"Баланс {balance}");
    Console.WriteLine("Введите команду:");
    command = Console.ReadLine();
if(command == "AddMoney")
{
}
else if(command == "GetChange")
{
}
else if (command.StartsWith("BuyGood"))
{
}
else
{
    Console.WriteLine("Команда неопределена");
}

Console.ReadLine();
}

if(command == "AddMoney")
{
    switch (payment)
    {
        case PaymentType.Coins:
        for(int i = 0; i < coinsValues.Length; i++)
        {
        Console.WriteLine($"Сколько монет номиналом {coinsValues[i]} вы хотите внести?");
        int count = 0;

        while
        (!int.TryParse(Console.ReadLine(), out count))
        {
            Console.WriteLine("Вы ввели не число!");
        }
        coinsQuantity[i] += count;
        balance += count *
        coinsValues[i];
        }
        break;

        case PaymentType.Card:
        Console.WriteLine("Сколько снять свашей карты?");
        int balanceDelta = 0;
        while
        (!int.TryParse(Console.ReadLine(),out balanceDelta))
        {
            Console.WriteLine("Вы ввелине число!");
        }
        balance += balanceDelta;
        Console.WriteLine("Баланс успешно пополнен");
        break;

        default:
        break;  
    }
}


enum PaymentType
{
    Coins,
    Card
}









