// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             matrix[i, j] =rnd.Next(min, max + 1);
        }
       
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        //  Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, ");
		else Console.Write(matrix[i, j]);
        }
        // Console.Write("]");
        Console.WriteLine();
    }
    
}

void ReplaceSqrEven(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
             matrix[i, j] *= matrix[i, j];
        }
       
    }
}
int[,] array = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(array);
ReplaceSqrEven(array);
Console.WriteLine();
PrintMatrix(array);


// 
// void ReplaceEvenElems(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i += 2)
//     {
//         for (int j = 0; j < array.GetLength(1); j += 2)
//         {
//             array[i, j] *= array[i, j];
//         }
//     }
// }

// int[,] array2d = CreateMatrixRndInt(3, 4, -10, 10);
// PrintMatrix(array2d);
// ReplaceEvenElems(array2d);
// Console.WriteLine();
// PrintMatrix(array2d);
