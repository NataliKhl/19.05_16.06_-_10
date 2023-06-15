// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

void FillMatrix(int[,] a)
{
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
           a[i,j] = random.Next(20);
        }
    }
}
void PrintMatrix(int[,] a)
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

int[,] a = new int[m, n];
FillMatrix(a);
PrintMatrix(a);

Console.Write("Введите номер строки: ");
int row = int.Parse(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int col = int.Parse(Console.ReadLine());

if (row >= 1 && col >= 1 && row <= a.GetLength(0) && col <= a.GetLength(1))
{
   Console.WriteLine(a[row-1, col-1]); 
}
else
{
    Console.WriteLine("Такого элемента в массиве нет"); 
}