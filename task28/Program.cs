// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.WriteLine("Введите натуральное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0) 
{
    int factorial = Factorial(num);
    Console.WriteLine($"Произведение чисел от 1 до {num} = {factorial}");
}
else Console.WriteLine("Введено не натуральное число");

int Factorial(int number)
{
    int res = 1;
    for (int i = 1; i <= number; i++)
    {
        res = res * i;
    }
    return res;
}
