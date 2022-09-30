// Задача 29
// Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

void FillArray(int[] array, int border)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-border, border);
    }
}

void SortArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int min = array[i];
        for (int j = i + 1; j < array.Length; j++)
        {
            if (Math.Abs(min) > Math.Abs(array[j]))
            {
                array[i] = array[j];
                array[j] = min;
                min = array[i];
            }
        }
    }
}

int size = 8, border = 100;
int[] array = new int[size];

FillArray(array, border);
Console.WriteLine($"Сгенерированный массив: [{String.Join(", ", array)}]");

SortArray(array);
Console.WriteLine($"Отсортированный массив: [{String.Join(", ", array)}]");