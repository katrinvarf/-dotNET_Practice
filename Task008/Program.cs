﻿// Задача 8
// Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число > 0: ");
int N = Convert.ToInt32(Console.ReadLine());

int i = 1;
while (i <= N)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i}, ");
    }
    i++;
}

Console.WriteLine();