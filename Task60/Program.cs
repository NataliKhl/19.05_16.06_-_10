// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)

void GenerateXYZArray()
{
    int X = 0;
    int Y = 0;
    int Z = 0;
    int GlobalCounter = 0;
    Console.Write("Введите значение измерения X:   ");
    X = int.Parse(Console.ReadLine());
    Console.Write("Введите значение измерения Y:   ");
    Y = int.Parse(Console.ReadLine());
    Console.Write("Введите значение измерения Z:   ");
    Z = int.Parse(Console.ReadLine());
    int[,,] Array = new int[X, Y, Z];
    int[] UsedNumbers = new int[Array.Length];
    Random Rand = new Random();
    for (int x = 0; x < X; x++)
    {
        for (int y = 0; y < Y; y++)
        {
            Console.WriteLine();
            for (int z = 0; z < Z; z++)
            {
                bool IsAdded = false;
                while (IsAdded == false)
                {
                    int AddingNubmer = Rand.Next(1, 100);
                    if (!UsedNumbers.Contains(AddingNubmer))
                    {
                        Array[x, y, z] = AddingNubmer;
                        UsedNumbers[GlobalCounter] = AddingNubmer;
                    }
                    IsAdded = true;
                    GlobalCounter++;
                }
                Console.Write(@"{0}  ({1};{2};{3})     ", Array[x, y, z], x, y, z);
            }
        }
    }
}
GenerateXYZArray();