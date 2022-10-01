// Задача 36
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.

void FillArray(int[] numbers, int border = 100)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(-border, border);
    }
}

int SumOddIndex(int[] numbers)
{
    int result = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (i % 2 != 0)
            result += numbers[i];
    }

    return result;
}

Console.Write("Укажите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int border = 10;
int[] numbers = new int[size];

FillArray(numbers, border);
Console.WriteLine($"Сгенерированный массив: [{String.Join(", ", numbers)}]");
Console.WriteLine($"Сумма элементов с нечётными индексами: {SumOddIndex(numbers)}");