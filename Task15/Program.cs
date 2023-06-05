// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
bool Weekend (int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}
bool ValDay (int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("Не может быть днём недели");
    return false;
}
int weekDay = Prompt("Введите день недели ");
if (ValDay(weekDay))
{
    if (Weekend(weekDay))
    {
        Console.WriteLine("Выходной день");
    }
    else 
    {
        Console.WriteLine("Рабочий день");
    }
}