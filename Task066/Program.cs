// Задача 66
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int CalcSum(int a, int b)
{
    if (a <= b)
    {
        return a + CalcSum(a + 1, b);
    }
    else
        return 0;
}

Console.WriteLine("Введите значения:");
Console.Write("M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("N = ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма натуральных чисел от {M} до {N}: {CalcSum(M, N)}");