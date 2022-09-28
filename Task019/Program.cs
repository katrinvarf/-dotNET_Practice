// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)
{
    int buf = number;
    int[] number_array = new int[5];
    int count = 0;

    while (buf > 0)
    {
        number_array[count] = buf % 10;
        buf = buf / 10;
        count++;
    }

    if (number_array[0] == number_array[4] && number_array[1] == number_array[3])
        Console.WriteLine($"Число {number} является палиндромом!");
    else
        Console.WriteLine($"Число {number} не является палиндромом!");

}
else
{
    Console.WriteLine("Вы ввели не пятизначное число!");
}