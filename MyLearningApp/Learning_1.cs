// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
string[] array = new string[5];
string[] array2 = array;

for (int i = 0; i < array.Length; i++)
{
    array[i] = "array" + i;
    Console.WriteLine(array2[i]);    
}

