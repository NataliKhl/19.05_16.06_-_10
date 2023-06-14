// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] a)
{
    Random random = new Random();
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = random.Next(-100, 100);
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

int SumOddPosition(int[] a)
{
    int sum = 0;
    for (int i = 0; i < a.Length; i+=2)
    {
       sum += a[i];
    }
    return sum;
}

Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine());

int[] a = new int[n];
FillArray(a);
PrintArray(a);
int sum = SumOddPosition(a);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sum}");