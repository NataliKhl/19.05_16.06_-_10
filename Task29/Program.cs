// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write("Введите элемент массива: ");
    a[i] = int.Parse(Console.ReadLine()); 
    }
}

void PrintArray(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i] + " ");
    }
}

int[] a = new int[8];
FillArray(a);
PrintArray(a);
