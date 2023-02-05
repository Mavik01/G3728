// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.


// Вводим числа через запятую в консоли
Console.Write("Введите числа через запятую: ");

// Создаем массив 
int[] arr = StringToArr(Console.ReadLine());
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine($"количество значений больше 0: {sum}");

// Создаем метод преобразования строки в массив
int[] StringToArr(string input)
{   
    int[] arr = new int [input.Length];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        arr[index] = Convert.ToInt32(temp);
        index++;
    }
    return arr;
}


// Второй вариант решения задачи 

// Console.Write("Введите числа через пробел: ");

// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); // Делаем преобразование строки чисел через пробел, введеной пользователем в массив
// int count = 0;
 
// for (int i = 0; i < arr.Length; i++) 
// {
//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }
 
// Console.WriteLine($"Количество чисел > 0: {count}");