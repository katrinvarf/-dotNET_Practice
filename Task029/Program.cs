// Задача 29
// Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

void FillArray(int[] numbers, int border)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(-border, border);
    }
}

void SortArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        int min = numbers[i];
        for (int j = i + 1; j < numbers.Length; j++)
        {
            if (Math.Abs(min) > Math.Abs(numbers[j]))
            {
                numbers[i] = numbers[j];
                numbers[j] = min;
                min = numbers[i];
            }
        }
    }
}

int size = 8, border = 100;
int[] numbers = new int[size];

FillArray(numbers, border);
Console.WriteLine($"Сгенерированный массив: [{String.Join(", ", numbers)}]");

SortArray(numbers);
Console.WriteLine($"Отсортированный массив: [{String.Join(", ", numbers)}]");