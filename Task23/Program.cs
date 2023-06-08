// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Write("N = ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    int result = (int)Math.Pow(i, 3);
    Console.WriteLine($"{i} | {result}");
}