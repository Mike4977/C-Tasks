// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"



Console.WriteLine("Введите натуральное число M: ");
Console.WriteLine("Введите натуральное число N: ");
int numberM = int.Parse(Console.ReadLine());
int numberN = int.Parse(Console.ReadLine());

void NaturalNumbers(int numM, int numN)
{
    
    if(numM > numN)
    {
        Console.Write($"{numM} ");
        NaturalNumbers(numM - 1, numN);
        // Console.Write($"{num} ");
    }
    else if(numM < numN)
    {
        // Console.Write($"{numN} ");
        NaturalNumbers(numM, numN - 1);
        Console.Write($"{numN} ");
    }
    else
    {
        Console.Write($"{numN} ");
    }
}

NaturalNumbers(numberM, numberN);