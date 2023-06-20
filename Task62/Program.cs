// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void SpiralFullfilling()
{
    int n = 4;
    int[,] Array = new int[n, n];
    int Rows = 0;
    int Columns = 0;
    int MovingX = 1;
    int MovingY = 0;
    int DirectionChangesCount = 0;
    int visits = n;
    for (int i = 0; i < Array.Length; i++)
    {
        Array[Rows, Columns] = i + 1;
        if (--visits == 0)
        {
            visits = n * (DirectionChangesCount % 2) + n * ((DirectionChangesCount + 1) % 2) - (DirectionChangesCount / 2 - 1) - 2;
            int temp = MovingX;
            MovingX = -MovingY;
            MovingY = temp;
            DirectionChangesCount++;
        }
        Columns += MovingX;
        Rows += MovingY;
    }
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write("  " + Array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}
SpiralFullfilling();
