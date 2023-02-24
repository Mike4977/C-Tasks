// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]



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

int[] NewArray(int[] arr)
{
    int[] newArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i] * -1;
    }
    return newArr;
}

int[] array = FillArrayRndInt(12, -9, 9);
int[] newArray = NewArray(array);
PrintArray(array);
Console.WriteLine();
PrintArray(newArray);