// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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

int RecursiveSumming(int currentsum,int m, int n)
{
    if (m == n)
    {
        currentsum += n;
        return currentsum;
    }
    else
    {
        currentsum += n;
    }

    return RecursiveSumming(currentsum, m, n - 1);
}

WriteLineWithIndent("Для рекурсивного вывода суммы элементов необходимо указать N и M");

int m = IntGuaranteedGet("Введите целое натуральное число M:");
int n = IntGuaranteedGet("Введите целое натуральное число N больше чем M:");

while (n < m)
{
    n = IntGuaranteedGet("Неверное значение N! Введите целое натуральное число N больше чем M:");
}

int summ = 0;

int result = RecursiveSumming(summ, m, n);

Console.WriteLine("M = {0}, N = {1} -> {2}", m, n, result);

