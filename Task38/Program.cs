// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void FillArray(double[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write("Введите элемент массива: ");
        a[i] = double.Parse(Console.ReadLine());
    }
}

void PrintArray(double[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i] + " ");
    }
    Console.WriteLine();
}

double FindMax(double[] a)
{
   double max = a[0];
   for (int i = 0; i < a.Length; i++)
   {
    if (a[i] > max)
        max = a[i];
   } 
   return max;
}

double FindMin(double[] a)
{
   double min = a[0];
   for (int i = 0; i < a.Length; i++)
   {
    if (a[i] < min)
        min = a[i];
   } 
   return min;
}

Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine());


double[] a = new double[n];
FillArray(a);
PrintArray(a);

double max = FindMax(a);
double min = FindMin(a);
double delta = max - min;
Console.WriteLine($"{max} - {min} = {delta}");