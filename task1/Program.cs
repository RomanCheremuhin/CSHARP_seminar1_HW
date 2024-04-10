﻿// Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

void Main()
{
    Console.Write("Введите значение M: ");
    int M = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите значение N: ");
    int N = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Натуральные числа от {M} до {N}:");
    PrintNaturalNumbers(M, N);
}

void PrintNaturalNumbers(int current, int N)
{
    if (current <= N)
    {
        Console.Write(current + " ");
        PrintNaturalNumbers(current + 1, N);
    }
}
Main();