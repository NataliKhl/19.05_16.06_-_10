﻿// Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Введите первое число");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число");
int num1 = Convert.ToInt32(Console.ReadLine()); 

if (num == num1 * num1)
{
   Console.WriteLine($"Да, {num} является квадратом числа {num1}"); 
}
else Console.WriteLine($"Нет, {num} не является квадратом числа {num1}"); 
