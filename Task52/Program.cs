// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillMatrix(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
           Console.Write("Введите элемент: ");
           a[i, j] = int.Parse(Console.ReadLine());
        }
    }
}
void PrintMatrix(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
           Console.Write(a[i,j] + " ");
        }
        Console.WriteLine();
    }
}

double[] FindAverage(int[,] a)
{
    double[] b = new double[a.GetLength(1)];
    for (int j = 0; j < a.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < a.GetLength(0); i++)
        {
            sum += a[i, j];
        } 
        b[j] = (double)sum / a.GetLength(0);
    }
    return b; 
}

Console.Write("m = ");
int m = int.Parse(Console.ReadLine());

Console.Write("n = ");
int n = int.Parse(Console.ReadLine());

int[,] a = new int[m, n];
FillMatrix(a);
PrintMatrix(a);

double[] b = FindAverage(a);
for (int i = 0; i < b.Length; i++)
{
    Console.Write($"{b[i]:f1} ");
}