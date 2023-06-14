// Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе
// 456 -> 3
// 78 -> 2
// 89126 ->

int DigitsInNumber(int num)
{
    int digits = 0;

    if (num == 0) return 1;
    else if (num > 0)
    {
        while (num > 0)
        {
            digits++;
            num /= 10;
        }
        
    }
    else if (num < 0)
    {
        while (num < 0)
        {
            digits++;
            num /= 10;
        }
        
    }
    return digits;
}

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{number} содержит {DigitsInNumber(number)} цифр");