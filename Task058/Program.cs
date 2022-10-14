// Задача 58
// Напишите программу, которая заполнит спирально массив 4 на 4.

void FillArray(int[,] numbers)
{
    int n = numbers.GetLength(0);

    int colStart = 0;
    int colStop = n - 1;
    int rowStart = 0;
    int rowStop = n - 1;

    int countActions = n + n;
    int k = 0;

    int value = 1;
    int sign = 1;

    while (k < countActions)
    {
        if (k % 2 == 0)
        {
            for (int j = rowStart; j * sign <= rowStop * sign; j += sign)
            {
                numbers[colStart, j] = value;
                value++;
            }
            colStart += sign;
            k++;
        }
        else
        {
            for (int i = colStart; i * sign <= colStop * sign; i += sign)
            {
                numbers[i, rowStop] = value;
                value++;
            }
            rowStop -= sign;

            int rowBuf = rowStart;
            rowStart = rowStop;
            rowStop = rowBuf;

            int colBuf = colStart;
            colStart = colStop;
            colStop = colBuf;

            sign *= -1;
            k++;
        }
    }
}

void PrintArray(int[,] numbers)
{
    int n = numbers.GetLength(0);

    Console.WriteLine("Заполненный массив:");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(numbers[i, j].ToString("D2") + " | ");
        }
        Console.WriteLine();
    }
}

int n = 4;

int[,] numbers = new int[n, n];

FillArray(numbers);
PrintArray(numbers);