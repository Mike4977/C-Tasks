// Задача 31: 
// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int[] FillArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] =rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
     Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
		else Console.Write(arr[i]);
    }
    Console.Write("]");
}



int[] GetSumPositiveNegativeElem(int[] arr)
{
    int sumPositiv = 0;
    int sumNegativ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sumNegativ += arr[i];
        else sumPositiv += arr[i];
    }
    return new int[]{sumNegativ, sumPositiv};
}



int GetSumNegativeElem (int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sum += arr[i];
    }

    return sum;
}

int GetSumPositiveElem (int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sum += arr[i];
    }

    return sum;
}

int[] array = FillArrayRndInt(12, -9, 9);
PrintArray(array);
int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(array);
Console.WriteLine($"Сумму положительных чисел = {sumPositiveNegativeElem[1]}");
Console.WriteLine($"Сумму отрицательных чисел = {sumPositiveNegativeElem[0]}");

 

int sumNegativeElem = GetSumNegativeElem(array);
int sumPositiveElem = GetSumPositiveElem(array);
Console.WriteLine($"Сумма положительных чисел = {sumPositiveElem}");
Console.WriteLine($"Сумма отрицательных чисел = {sumNegativeElem}");