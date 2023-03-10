// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число степени: ");
int power = int.Parse(Console.ReadLine());
if(power < 0) Console.WriteLine("Неверное число степени");
else Console.WriteLine(PowNum(number, power));
int PowNum(int num, int pow)
 {
     if (pow == 0) return 1;
     else return num * PowNum(num, pow - 1);
//     if (n == 0) return 1;
//     else return PowNum(a, b - 1) * n;
 }

 

