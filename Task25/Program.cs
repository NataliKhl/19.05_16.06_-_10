// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int MyPow(int a, int b)
{
    int res = 1;
    for (int i = 0; i < b; i++)
    {
        res = res * a;
    }
    return res;
}

Console.Write("A = ");
int a = int.Parse(Console.ReadLine());

Console.Write("B = ");
int b = int.Parse(Console.ReadLine());

int res = MyPow(a, b);
Console.WriteLine($"Результат = {res}");