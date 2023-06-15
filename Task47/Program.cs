// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillMatrix(double[,] a)
{
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
           a[i,j] = Math.Round(random.NextDouble() * random.Next(-10, 10), 1);
        }
    }
}
void PrintMatrix(double[,] a)
{
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
           Console.Write(a[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("m = ");
int m = int.Parse(Console.ReadLine());

Console.Write("n = ");
int n = int.Parse(Console.ReadLine());

double[,] a = new double[m, n];
FillMatrix(a);
PrintMatrix(a);