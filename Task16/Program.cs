// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());


if(Method(numA, numB)) System.Console.WriteLine("Yes");
else System.Console.WriteLine("No");


bool Method (int num1, int num2)
{
    return (num1 % num2) ==0 || (num2 % num1) ==0;
}

