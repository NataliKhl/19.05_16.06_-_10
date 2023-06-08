// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigits(int n)
{
    int sum = 0;
    while (n > 0)
    {
        int a = n % 10;
        sum += a;
        n = n / 10; 
    }
    return sum;
}


Console.Write("N = ");
int n = int.Parse(Console.ReadLine());
int sum = SumDigits(n);
Console.WriteLine($"Сумма = {sum}");