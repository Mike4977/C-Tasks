// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int numberOfDigits = NumberOfDigits(num);
Console.WriteLine(numberOfDigits);

int NumberOfDigits(int number)
{
    int count = 0;
    while (number != 0)
    {
         number = number / 10;
         count++;
    }
    return count;
}