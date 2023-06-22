// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

void WriteLineWithIndent(string text)
{
    Console.WriteLine(text);
    Console.WriteLine("________________________");
    Console.WriteLine();
}

uint ParseStringFromConsole(string text)
{
    WriteLineWithIndent(text);
    uint number;
    if (uint.TryParse(Console.ReadLine(), out number)) return number;
    else return 0;
}

uint IntGuaranteedGet(string text)
{
    uint number = 0;
    bool numberisok = false;
    while (numberisok == false)
    {
        number = ParseStringFromConsole(text);
        if (number >= 0) numberisok = true;
    }
    return number;
}

uint CountAkkermanFunctionRecursive(uint m, uint n)
{
    if (m == 0) return n + 1;
    else

    if ((m > 0) && (n == 0))
        return CountAkkermanFunctionRecursive(m-1,1);

    else
        return CountAkkermanFunctionRecursive((m - 1), CountAkkermanFunctionRecursive(m, n - 1));
}

WriteLineWithIndent("Для подсчета функции Аккермана необходимо указать целые неотрицательные M и N");

uint m = IntGuaranteedGet("Введите целое натуральное число M:");
uint n = IntGuaranteedGet("Введите целое натуральное число N:");

uint result = CountAkkermanFunctionRecursive(m, n);

Console.WriteLine(" Результат высчисления функции Аккермана для М = {0} и  N = {1} : {2}", m, n, result);