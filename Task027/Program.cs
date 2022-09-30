// Задача 27
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumOfDigits(int num)
{
    int result = 0;
    int buf = num;

    while (buf > 0)
    {
        result += buf % 10;
        buf /= 10;
    }

    return result;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр в числе {number}: {SumOfDigits(number)}");