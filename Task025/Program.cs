// Задача 25
// Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.

double Pow(int A, int B)
{
    double result = 1;
    for (int i = 0; i < B; i++)
    {
        result *= A;
    }
    return result;
}

Console.Write("Введите число A = ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B = ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{A} в степени {B} = {Pow(A, B)}");