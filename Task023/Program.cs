﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N = ");
int N = Convert.ToInt32(Console.ReadLine());

double[] table = new double[N];

int i = 1;
while (i <= N)
{
    table[i-1] = Math.Pow(i, 3);
    i++;
}

Console.WriteLine($"Таблица кубов чисел от 1 до {N}: {String.Join(", ", table)}");