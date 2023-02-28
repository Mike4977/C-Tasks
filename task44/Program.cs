// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int Promt(string message)
{
    Console.Write(message);
    string value = (Console.ReadLine());
    int result = Convert.ToInt32(value);
    Console.WriteLine();
    return result;
}

int[] FibonacciNum (int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
   
    arr[0]=0;
    arr[1]=1;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i-1]+arr[i-2];
    }
    return arr;
}

void PrintArray (int[] arr)
{
    // Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]} ");
        else Console.Write($"{arr[i]}");
    }
    // Console.WriteLine("]");
}

int num=Promt("Введите число N: ");
if(num < 2) Console.WriteLine("Ввели некорректное число");
else
{
    int[] array = FibonacciNum(num);
    PrintArray(array);
}
