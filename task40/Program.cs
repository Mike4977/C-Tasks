// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

int Promt(string message)
{
    Console.WriteLine(message);
    string value = (Console.ReadLine());
    int result = Convert.ToInt32(value);
    return result;
}

bool CheckLengthSize(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

int sizeA = Promt ("Введите первое число");
int sizeB = Promt ("Введите второе число");
int sizeC = Promt ("Введите третье число");

bool triangleExist = CheckLengthSize(sizeA, sizeB, sizeC);
// if(triangleExist) Console.Write("Треугольник существует");
// else Console.Write("Треугольник не существует");

Console.Write(triangleExist ? "Треугольник существует" : "Треугольник не существует");
