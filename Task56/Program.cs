// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
// 1 строка

int RowsCount = 0, ColumnsCount = 0;

int[,] CreatedArray = CreateArray();
PrintArray(CreatedArray, "Сгенерированный массив!");

int Index = FindRowWithMinimalSumm(CreatedArray);

Console.WriteLine(@"В строке # {0} минимальная сумма", Index+1);

//Task56

int[,] CreateArray()
{
    WriteLineWithIndent("Начало создания массива");

    bool RowsIsRight = false, ColumnsIsRight = false;
    while (RowsIsRight == false)
    {
        int Nubmer = ReturnIntFromString("Введите количество   строк");
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
        int Nubmer = ReturnIntFromString("Введите количество  столбцов");
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

int FindRowWithMinimalSumm(int[,] Array)
{
    int IndexOfRowWithMinimalSumm = 0;
    int MinimalSumm = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        int LocalSumm = 0;
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            LocalSumm += Array[i, j];
        }
        if (MinimalSumm == 0)
        {
            MinimalSumm = LocalSumm;
        }
        else
        {
            if (LocalSumm < MinimalSumm)
            {
                MinimalSumm = LocalSumm;
                IndexOfRowWithMinimalSumm = i;
            }
        }
    }
    return IndexOfRowWithMinimalSumm;
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


