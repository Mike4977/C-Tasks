// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
Console.Write("Номер  ");
string num = Console.ReadLine();

string quarter = Quarter(num);

Console.WriteLine($"Заданной четверти соответствует диапазон координат {quarter}");


string Quarter(string number)
{
    if (number == "1") return "x > 0, y > 0";
    if (number == "2") return "x < 0, y > 0";
    if (number == "3") return "x < 0, y < 0";
    if (number == "4") return "x > 0, y < 0";
    return "0";
}
    
