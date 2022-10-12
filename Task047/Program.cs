// Задача 47
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.

void FillArray(double[,] numbers, int m, int n)
{
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            //numbers[i, j] = Convert.ToDouble(random.Next(-100000, 100000)) / 10;
            numbers[i, j] = Math.Round(Math.Pow(-1, random.Next(0, 2)) * random.NextDouble() * Math.Pow(10, random.Next(1, 5)), 1);
        }
    }
}

void PrintArray(double[,] numbers, int m, int n)
{
    Console.WriteLine("Сгенерированный массив");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(numbers[i, j] + " | ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размерность двумерного массива:");
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[m, n];

FillArray(numbers, m, n);
PrintArray(numbers, m, n);