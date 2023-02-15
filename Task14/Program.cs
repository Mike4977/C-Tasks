// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

bool Metod (int currentNum, int numA, int numB)
{
    return currentNum % numA == 0 && currentNum % numB == 0;
}

Console.WriteLine("Введите число");
int currentNumber = Convert.ToInt32(Console.ReadLine());

int numberA = 7, numberB =23;

if(Metod(currentNumber, numberA, numberB))  Console.WriteLine("Да");
else  Console.WriteLine("Нет");
