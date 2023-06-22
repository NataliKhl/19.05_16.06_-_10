// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void ShowArrayOnScreen(int[,] Array)
{
    Console.WriteLine();
    for (int i = 0; i < Array.GetLength(0); i++)
    {

        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write("   " + Array[i, j].ToString() + "   ");
        }
        Console.WriteLine();

    }
}

int[,] MatrixMultiplication(int[,] MatrixX, int[,] MatrixY)
{
    int[,] ResultMatrix = new int[MatrixX.GetLength(0), MatrixY.GetLength(1)];
    for (int i = 0; i < ResultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < ResultMatrix.GetLength(1); j++)
        {
            ResultMatrix[i, j] = 0;
            for (int k = 0; k < MatrixX.GetLength(1); k++)
            {
                ResultMatrix[i, j] += MatrixX[i, k] * MatrixY[k, j];
            }
        }
    }
    return ResultMatrix;
}

void GenerateBothMatrix()
{
    int FirstMatrixRows = 0;
    int FirstMatrixColumns = 0;
    int SecondMatrixRows = 0;
    int SecondMatrixColumns = 0;
    Console.WriteLine("Введите количество строк второй матрицы, и столбцов первой матрицы ");
    FirstMatrixColumns = int.Parse(Console.ReadLine());

    SecondMatrixRows = FirstMatrixColumns;

    Console.Write("Введите количество столбцов второй матрицы:  ");
    SecondMatrixColumns = int.Parse(Console.ReadLine());
    Console.Write("Введите количество строк первой матрицы:");
    FirstMatrixRows = int.Parse(Console.ReadLine());

    int[,] FirstMatrix = new int[FirstMatrixRows, FirstMatrixColumns];
    int[,] SecondMatrix = new int[SecondMatrixRows, SecondMatrixColumns];

    Random Rand = new Random();
    for (int i = 0; i < FirstMatrixRows; i++)
    {
        for (int j = 0; j < FirstMatrixColumns; j++)
        {
            FirstMatrix[i, j] = Rand.Next(1, 100);
        }
    }
    for (int i = 0; i < SecondMatrixRows; i++)
    {
        for (int j = 0; j < SecondMatrixColumns; j++)
        {
            SecondMatrix[i, j] = Rand.Next(1, 100);
        }
    }
    
    int[,] ResultMatrix = MatrixMultiplication(FirstMatrix, SecondMatrix);
    ShowArrayOnScreen(ResultMatrix);
}

GenerateBothMatrix();