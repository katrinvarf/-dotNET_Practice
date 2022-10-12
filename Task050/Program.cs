// Задача 50
// Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void FillArray(int[,] numbers, int m, int n, int border = 50)
{
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            numbers[i, j] = random.Next(-border, border);
        }
    }
}

void CheckElement(int[,] numbers, int i, int j, int m, int n)
{
    if (0 <= i && i < m && 0 <= j && j < n)
    {
        Console.WriteLine($"Значение элемента в ячейке [{i + 1}, {j + 1}]: {numbers[i, j]}");
    }
    else
    {
        Console.WriteLine("Такого числа в массиве нет!");
    }
}

void PrintArray(int[,] numbers, int m, int n)
{
    Console.WriteLine("Исходный массив:");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(numbers[i, j] + " | ");
        }
        Console.WriteLine();
    }
}

Random random = new Random();
int m = random.Next(1, 10);
int n = random.Next(1, 10);

int[,] numbers = new int[m, n];
FillArray(numbers, m, n);
PrintArray(numbers, m, n);

Console.WriteLine("Введите индексы элемента двумерного массива:");
Console.Write("i = ");
int i = Convert.ToInt32(Console.ReadLine());

Console.Write("j = ");
int j = Convert.ToInt32(Console.ReadLine());

CheckElement(numbers, i - 1, j - 1, m, n);
