// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа
// 78 -> 8
// 12 -> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;
if(firstDigit > secondDigit) 
    Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
else 
    Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

// Решение через Тернарный оператор:

int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

// Решение через функцию:

int maxDigit = MaxDigit(number); // вызов метода, можно вызывать из любого места, 
//далее number попадает в num

int MaxDigit (int num) //num = number/ вход
{
    int firstDigit = num / 10; // алгоритм (три строки)
    int secondDigit = num % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return maxDigit; // выход
}