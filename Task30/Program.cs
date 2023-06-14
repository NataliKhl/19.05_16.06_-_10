// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями в случайном порядке
// [1,0,1,1,0,1,0,0] 

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(2);  
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] array1 = new int[8];
FillArray(array1);
PrintArray(array1);
