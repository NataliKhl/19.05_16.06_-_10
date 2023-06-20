// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int RowsCount = 0, ColumnsCount = 0;

int[,] CreatedArray = CreateArray();
PrintArray(CreatedArray, "Сгенерированный массив!");

Console.WriteLine();

int[,] SortedArray = SortArray(CreatedArray);
PrintArray(SortedArray,"Отсортированный массив!");



int[,] CreateArray()
{
    WriteLineWithIndent("Начало создания массива");

    bool RowsIsRight = false, ColumnsIsRight = false;
    while (RowsIsRight == false)
    {
        int Nubmer = ReturnIntFromString("Введите количество   строк");
        if (Nubmer == 0)
        {
            WriteLineWithIndent("Необходимо ввести число, повторите ввод!");
        }
        else
        {
            RowsIsRight = true;
            RowsCount = Nubmer;

        }
    }
    Console.WriteLine();
    while (ColumnsIsRight == false)
    {
        int Nubmer = ReturnIntFromString("Введите количество  столбцов");
        if (Nubmer == 0)
        {
            WriteLineWithIndent("Необходимо ввести число, повторите ввод!");
        }
        else
        {
            ColumnsIsRight = true;
            ColumnsCount = Nubmer;

        }
    }
    Console.WriteLine();

    int[,] ArrayInMethod = new int[RowsCount, ColumnsCount];

    for (int i = 0; i < RowsCount; i++)
        for (int j = 0; j < ColumnsCount; j++)
        {
            Random newRandomNumber = new Random();
            ArrayInMethod[i, j] = newRandomNumber.Next(1, 9);
        }
    return ArrayInMethod;
}

void PrintArray(int[,] ArrayForMethod, string Text)
{
    WriteLineWithIndent(Text);
    for (int i = 0; i < ArrayForMethod.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < ArrayForMethod.GetLength(1); j++)
        {

            Console.Write(ArrayForMethod[i, j] + "  ");
        }
    }

    Console.WriteLine();
}

int[,] SortArray(int[,] Array)
{
    bool IsSorted = true;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (IsSorted == false)
            {
                if (i != 0)
                {
                    i = i - 1;
                    IsSorted = true;
                }
            }
            if (j != Array.GetLength(1) - 1)
            {
                if (Array[i, j] < Array[i, j + 1])
                {
                    int buff = Array[i, j];
                    Array[i, j] = Array[i, j + 1];
                    Array[i, j + 1] = buff;
                    IsSorted = false;
                }
            }
        }
    }
    return Array;
}

void WriteLineWithIndent(string Text)
{
    Console.WriteLine(Text);
    Console.WriteLine("________________________");
    Console.WriteLine();
}

int ReturnIntFromString(string Text)
{
    WriteLineWithIndent(Text);
    int Number;

    if (int.TryParse(Console.ReadLine(), out Number)) return Number;
    else return 0;
}


