// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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
int[] Gen1DArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}
// Метод вывода результата созданного массива
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
// Метод суммиурет эллементы стоящие на нечетных позициях в массиве
int SumPos (int[] arr)
{
    int res = 0;
    for (int i=1; i<arr.Length; i=i+2)
    {
        res += arr[i];
    }
    return res;
}

int len = ReadData("Введите длину массива: ");
int b = ReadData("Введите начало массива: ");
int e = ReadData("Введите окончание массива: ");
int[] testArr = Gen1DArray(len,b,e);
Print1DArr(testArr);
int result = SumPos(testArr);
PrintData("Сумма элементов, стоящих на нечетных позициях: "+result);