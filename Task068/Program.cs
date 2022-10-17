// Задача 68
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int FuncAckermann(int M, int N)
{
    if (M == 0)
        return N + 1;

    else if (M > 0 && N == 0)
        return FuncAckermann(M - 1, 1);

    else if (M > 0 && N > 0)
        return FuncAckermann(M - 1, FuncAckermann(M, N - 1));

    else return 0;
}

Console.WriteLine("Введите значения:");
Console.Write("M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("N = ");
int N = Convert.ToInt32(Console.ReadLine());

int value = FuncAckermann(M, N);
if (value == 0)
    Console.WriteLine($"На вход подаются только неотрицательные числа!");
else
    Console.WriteLine($"Результат вычисления функции Аккермана: {value}");

