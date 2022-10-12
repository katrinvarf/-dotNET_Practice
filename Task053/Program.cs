// Задача 52
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FillArray(int[,] numbers, int m, int n, int border = 100)
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

void CalcAverage(int[,] numbers, int m, int n)
{
    double[] sums = new double[n];
    Console.WriteLine("Среднее арифметическое:");
    for (int j = 0; j < n; j++)
    {
        for (int i = 0; i < m; i++)
        {
            sums[j] += numbers[i, j];
        }
        Console.Write(Math.Round(sums[j] / m, 1) + " | ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите размерность двумерного массива:");
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[m, n];

FillArray(numbers, m, n);
PrintArray(numbers, m, n);
CalcAverage(numbers, m, n);