// Задача 41
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа через Enter:");
int count = 0;
string inputText = "";

while ((inputText = Console.ReadLine()) != "")
{
    int number = Convert.ToInt32(inputText);
    if (number > 0) count++;
}

Console.WriteLine($"Количество чисел > 0: {count}");