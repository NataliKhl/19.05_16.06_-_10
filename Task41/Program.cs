// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

void FillArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write("Введите элемент массива: ");
        a[i] = int.Parse(Console.ReadLine());
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

int CountPositive(int[] a)
{
   int count = 0;
   for (int i = 0; i < a.Length; i++)
   {
    if (a[i] > 0)
        count++;
   } 
   return count;
}


Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine());

int[] a = new int[n];
FillArray(a);
PrintArray(a);

int count = CountPositive(a);
Console.WriteLine($"Количество положительных чисел = {count}");