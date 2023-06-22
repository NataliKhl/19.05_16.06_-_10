// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
//     Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
//     сумма отрицательных равна -20.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr, string sep = ",")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write ($"{arr[i]}{sep} ");
        else Console.Write ($"{arr[i]}");
    }
}

int[] GetSumPositivNegativElem(int[] arr)
{
    int sumPositive = 0;
    int sumNegative = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sumPositive += arr[i];
        else sumNegative += arr[i];
    }
    return new int[] {sumPositive, sumNegative};
}

int GetSumPositivElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sum += arr[i];
    }
    return sum;
}

int GetSumNegativElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sum += arr[i];
    }
    return sum;
}

int[] array = CreateArrayRndInt(12, -9, 9);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

int[] sumPositivNegativElem = GetSumPositivNegativElem(array);
Console.WriteLine($"Сумма положительных элементов = {sumPositivNegativElem[0]}");
Console.WriteLine($"Сумма отрицательных элементов = {sumPositivNegativElem[1]}");

int sumPositivElem = GetSumPositivElem(array);
int sumNegativElem = GetSumNegativElem(array);
Console.WriteLine($"Сумма положительных элементов = {sumPositivElem}");
Console.WriteLine($"Сумма отрицательных элементов = {sumNegativElem}");
