string[] array1 = new string[] { "hello", "2", "world", ":-)" };
string[] array2 = new string[] { "1234", "1567", "-2", "computer science" };
string[] array3 = new string[] { "Russia", "Denmark", "Kazan" };

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < (array.Length - 1); i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[(array.Length - 1)]}]");
    Console.WriteLine();
}

PrintArray(array1);
PrintArray(array2);
PrintArray(array3);

void SortArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write($"{array[i]} ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine();

SortArray(array1);
SortArray(array2);
SortArray(array3);
