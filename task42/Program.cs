// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


int Promt(string message)
{
    Console.WriteLine(message);
    string value = (Console.ReadLine());
    int result = Convert.ToInt32(value);
    return result;
}

// string BinaryNum(int decimalNumber)
// {
//     var binaryNumber = string.Empty;
//         while (decimalNumber > 0)
//         {
//             binaryNumber = (decimalNumber % 2) + binaryNumber;
//             decimalNumber /= 2;
//         }
//     return binaryNumber;
// }

int BinaryNum(int num)
{
    int multiplier = 1;
    int bin = 0;
    while(num > 0)
    {
        bin = bin + (num % 2) * multiplier;
        num /= 2;
        multiplier *= 10;
    }
    return bin;
}
int number = Promt ("Введите число");
Console.WriteLine(BinaryNum(number));