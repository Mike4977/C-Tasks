// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нетate for more information

Console.WriteLine("Ведите число 1");
int sqr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите число 2");
int number = Convert.ToInt32(Console.ReadLine());

if(sqr == number * number)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}