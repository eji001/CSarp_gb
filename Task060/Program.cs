// Задача 56: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void MinElement(int[] array)
{
    int min = array[0];
    int resMin = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            resMin = i;
        }
    }
    // return resMin;
    Console.WriteLine();
    Console.WriteLine($"в строке {resMin} сумма наименьших элементов минимальна и равна {min}");
}

int[] ArraySumOfMatrixRows(int[,] matrix)
{
    int[] arraySum = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arraySum[i] += matrix[i, j];
        }
    }
    return arraySum;
}

int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int colunm = 0; colunm < columnCount; colunm++)
        {
            array[row, colunm] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

//
void PrintMatrix(int[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int colunm = 0; colunm < arr.GetLength(1); colunm++)
        {
            Console.Write($"{arr[row, colunm]}\t");
        }
        Console.WriteLine();
    }
}

// печать массива
void PrintArray(int[] myarr)
{
    for (int i = 0; i < myarr.Length; i++)
    {
        Console.Write($"{myarr[i]}\n");
    }
}

int[,] matrix = CreateMatrix(6, 3, 0, 9);
PrintMatrix(matrix);
Console.WriteLine();

int[] array = ArraySumOfMatrixRows(matrix);
PrintArray(array);

MinElement(array);
