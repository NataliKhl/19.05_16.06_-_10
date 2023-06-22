// Задайте значение N. Напишите программу, которая выведет все натуральные числа
//  в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void WriteLineWithIndent(string text)
{
    Console.WriteLine(text);
    Console.WriteLine("________________________");
    Console.WriteLine();
}

int ParseStringFromConsole(string text)
{
    WriteLineWithIndent(text);
    int number;
    if (int.TryParse(Console.ReadLine(), out number)) return number;
    else return 0;
}

int IntGuaranteedGet(string text)
{
    int number = 0;
    bool numberisok = false;
    while (numberisok == false)
    {
        number = ParseStringFromConsole(text);
        if (number > 0) numberisok = true;
    }
    return number;
}

void ReturnNumbers(int number)
{ 
    if (number == 1) Console.Write(1 + " ");
    else
    {
        Console.Write(number + " ");
        ReturnNumbers(number - 1);
    }
}


WriteLineWithIndent("Рекурсивный вывод значений");
ReturnNumbers(IntGuaranteedGet("Введите целое натуральное число N для рекурсивного вывода значений от N до 0"));

