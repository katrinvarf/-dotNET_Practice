// Задача 54
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void FillArray(int[,] numbers, int border = 50)
{
    int m = numbers.GetLength(0);
    int n = numbers.GetLength(1);

    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            numbers[i, j] = random.Next(0, border);
        }
    }
}

void PrintArray(int[,] numbers)
{
    int m = numbers.GetLength(0);
    int n = numbers.GetLength(1);

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(numbers[i, j] + " | ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] numbers)
{
    int m = numbers.GetLength(0);
    int n = numbers.GetLength(1);

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = j + 1; k < n; k++)
            {
                if (numbers[i, j] < numbers[i, k])
                {
                    int buf = numbers[i, j];
                    numbers[i, j] = numbers[i, k];
                    numbers[i, k] = buf;
                }
            }
        }
    }
}

Random random = new Random();
int n = random.Next(3, 7);
int m = random.Next(3, 7);

int[,] numbers = new int[m, n];

FillArray(numbers);
Console.WriteLine("Исходный массив:");
PrintArray(numbers);

SortArray(numbers);
Console.WriteLine("Отсортированный массив:");
PrintArray(numbers);