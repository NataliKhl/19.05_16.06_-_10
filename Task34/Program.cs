// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] a)
{
    Random random = new Random();
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = random.Next(100, 1000);
    }
}

void PrintArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i] + " ");
    }
    Console.WriteLine();
}

int CountEven(int[] a)
{
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine());

int[] a = new int[n];
FillArray(a);
PrintArray(a);
int count = CountEven(a);
Console.WriteLine($"Кол-во четных чисел = {count}");
