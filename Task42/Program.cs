// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

int GetNumber()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) return number;
    else return -1;
}

int ConvertToBin(int num)
{
    int binNum = 0;
    int mult = 1;
    while (num > 0);
    {
        binNum = binNum + (num % 2 * mult);
        mult = mult * 10;
        num = num / 2;
    }
    return binNum;
}

int number = GetNumber();

if (number == -1)
{
    Console.WriteLine("Число должно быть не отрицательным");
    return;
}

Console.WriteLine($"Число {number} в двоичном представлении -> {ConvertToBin(number)}");