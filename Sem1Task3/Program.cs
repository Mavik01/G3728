//Считываем данные с консоли 
string? imputLine = Console.ReadLine();
// Проверяем, чтобы данные не были пустыми
if (imputLine != null)
{
    //Вариант1
    // // Создаем массив с днями недели
    //     string[] dayofWeek = new string[7];
    //     dayofWeek[0] = "понедельник";
    //     dayofWeek[1] = "вторник";
    //     dayofWeek[2] = "среда";
    //     dayofWeek[3] = "четверг";
//Вариант 2
    int imputNumber = int.Parse(imputLine);
    // string outDayOfWeek = string.Empty;
    // switch (imputNumber)
    // {
    //     case 1: outDayOfWeek = "понедельник"; break;
    //     case 2: outDayOfWeek = "вторник"; break;
    //     case 3: outDayOfWeek = "среда"; break;
    //     case 4: outDayOfWeek = "четверг"; break;
    //     case 5: outDayOfWeek = "пятница"; break;
    //     case 6: outDayOfWeek = "суббота"; break;
    //     case 7: outDayOfWeek = "воскресенье"; break;
    //     default: outDayOfWeek = "это не день недели!"; break;
    // }
    // Console.WriteLine(outDayOfWeek);
    //Вариант 3

    string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(imputNumber));
    Console.WriteLine(outDayOfWeek);
}


