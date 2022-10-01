// Задача 34
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных

void FillArray(int[] numbers)
{
    Random random = new Random();
    int minValue = 100;
    int maxValue = 1000;

    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(minValue, maxValue);
    }
}

int CountEvenNumbers(int[] numbers)
{
    int result = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
            result++;
    }

    return result;
}

Console.Write("Укажите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

FillArray(numbers);
Console.WriteLine($"Сгенерированный массив: [{String.Join(", ", numbers)}]");
Console.WriteLine($"Количество четных чисел в массиве: {CountEvenNumbers(numbers)}");