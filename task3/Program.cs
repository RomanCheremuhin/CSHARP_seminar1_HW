// Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

void Main()
{
    int[] myArray = { 1, 2, 5, 0, 10, 34 };

    Console.WriteLine("Элементы массива, начиная с конца:");
    PrintArrayReverse(myArray, myArray.Length - 1);
}

void PrintArrayReverse(int[] arr, int i)
{
    if (i >= 0)
    {
        Console.Write(arr[i] + " ");
        PrintArrayReverse(arr, i - 1);
    }
}
Main();