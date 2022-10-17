// Задача 64
// Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.

void GetNumbers(int a, int b)
{
    if (a < b)
    {
        if (a % 3 == 0)
            Console.Write(a + " ");
        GetNumbers(a + 1, b);
    }
    else
        Console.WriteLine();
}

Console.WriteLine("Введите значения:");
Console.Write("M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("N = ");
int N = Convert.ToInt32(Console.ReadLine());

GetNumbers(M, N);

