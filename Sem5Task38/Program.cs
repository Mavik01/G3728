// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


// Считываем данные с консоли

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод вывода сообщения
void PrintData(string res)
{
    Console.WriteLine(res);
}
// Метод создания нового массива с случайными элементами
double[] Gen1DArray(int len, double begin, double end)
{
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
    return arr;
}
// Метод вывода результата созданного массива
void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

double MinMax(double[] arr)
{
    double max = Int32.MinValue;
    double min = Int32.MaxValue;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }

    return (max - min);
}

int len = ReadData("Введите длину массива: ");
double b = ReadData("Введите начало массива: ");
double e = ReadData("Введите окончание массива: ");
double[] testArr = Gen1DArray(len, b, e);
Print1DArr(testArr);
double result = MinMax(testArr);
PrintData("разница между максимальным и минимальным значениями: " + result);

