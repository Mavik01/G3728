// Задача №0
// Напишите программу, которая на вход принимает
// число и выдает его квадрат (число умноженное на
// само себя)

String? inputNum = Console.ReadLine();
if(inputNum!=null)

{

    int number = int.Parse(inputNum);

    int result = number*number;


    Console.WriteLine(result);


}

