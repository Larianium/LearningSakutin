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


