// Задача 38
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(double[] numbers, int border = 10000)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(random.Next(-border, border)) / 100;
    }
}

double FindDiff(double[] numbers)
{
    double result = 0, min = numbers[0], max = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (Math.Abs(min) > Math.Abs(numbers[i]))
            min = numbers[i];

        if (Math.Abs(max) < Math.Abs(numbers[i]))
            max = numbers[i];
    }

    result = Math.Round(Math.Abs(max) - Math.Abs(min), 2);

    return result;
}

Console.Write("Укажите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];

FillArray(numbers);
Console.WriteLine($"Исходный массив: {String.Join(" ", numbers)}");
Console.WriteLine($"Разница между максимальным и минимальным элементами: {FindDiff(numbers)}");