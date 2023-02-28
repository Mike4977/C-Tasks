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
    int bin = 0;
    while(num > 0)
    {
        bin = (num % 2) + bin;
        num /= 2;
        bin *= 10;
    }
}
int number = Promt ("Введите число");
Console.WriteLine(BinaryNum(number));