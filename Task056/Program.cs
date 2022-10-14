// Задача 56
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void FillArray(int[,] numbers, int border = 10)
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

int FindMinSum(int[,] numbers)
{
    int m = numbers.GetLength(0);
    int n = numbers.GetLength(1);

    int minIndex = 0;
    int minSum = 0;

    for (int i = 0; i < m; i++)
    {
        int sumRow = 0;
        for (int j = 0; j < n; j++)
        {
            sumRow += numbers[i, j];
        }

        if (i == 0)
        {
            minSum = sumRow;
        }
        else
        {
            if (sumRow < minSum)
            {
                minIndex = i;
                minSum = sumRow;
            }
        }
    }
    return minIndex + 1;
}

Random random = new Random();
int leftBorder = 3;
int rightBorder = 4;
int n = random.Next(leftBorder, rightBorder);
int m = random.Next(n + leftBorder, n + rightBorder);

int[,] numbers = new int[m, n];

FillArray(numbers);
PrintArray(numbers);
Console.WriteLine($"Наименьшая сумма элементов в строке: {FindMinSum(numbers)}");