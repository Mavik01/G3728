// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Считываем данные пользователя
Console.WriteLine("Введите число: ");
string pal = Console.ReadLine();

// Вводим переменную равную длине массива
int n = pal.Length;

if (n == 5)
{
    if (pal[0] == pal[4] && pal[1] == pal[3])
    {
        Console.WriteLine("Палиндром");
    }
    else
    {
        Console.WriteLine("не палиндром");
    }
}
else
{
    Console.WriteLine("не пятизначное число");
}
