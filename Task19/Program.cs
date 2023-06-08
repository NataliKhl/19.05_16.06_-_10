// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool ChekPalindrome(int n)
{
    int a = n % 10;
    int b = n / 10 % 10;
    int c = n / 100 % 10;
    int d = n / 1000 % 10;
    int e = n / 10000;

    if (a == e && b == d)
        return true;
    else
        return false;  
}

bool ChekPalindrome2(int n)
{
    int m = n;
    int res = 0;
    while (m > 0)
    {
        int a = m % 10;
        res = res * 10 + a;
        m = m / 10;
    }    

    if (res == n)
        return true;
    else
        return false;  
}

Console.WriteLine("Введите число");
int y = int.Parse(Console.ReadLine());
if (ChekPalindrome2(y) == true)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");