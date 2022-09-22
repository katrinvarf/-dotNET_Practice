//Задача 13
// Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
    Console.WriteLine("Третьей цифры нет!");
else
{
    int res = number;
    while (res > 1000)
    {
        res = res / 10;
    }

    Console.WriteLine($"Третья цифра числа {number}: {res % 10}");
}