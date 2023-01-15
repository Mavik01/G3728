// Задача №4
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из
// этих чисел.

// Считываем данные с консоли 1 число
string? inputNum1 = Console.ReadLine();

// Считываем данные с консоли 2 число
string? inputNum2 = Console.ReadLine();

// Считываем данные с консоли 3 число
string? inputNum3 = Console.ReadLine();

// Проверяем что бы данные не были пустыми

if ((inputNum1 != null) && (inputNum2 != null) && (inputNum3 != null))

{

//Парсим введеное числа
int num1 = int.Parse(inputNum1);
int num2 = int.Parse(inputNum2);
int num3 = int.Parse(inputNum3);

// Сравниваем введеные числа
if (num1 > num2)
{
    if (num1 > num3)
// выводим результат в консоли
    {
        Console.Write("Наибольшим числом является ");
        Console.WriteLine(num1);
    }
    else
    {
        Console.Write("Наибольшим числом является ");
        Console.WriteLine(num3);
    }
}
else
{
    if (num2 > num3)
    {
       Console.Write("Наибольшим числом является ");
       Console.WriteLine(num2); 
    }
    else
    {
        Console.Write("Наибольшим числом является ");
        Console.Write(num3);
    }

}

}




