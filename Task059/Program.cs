// Задача 54: Задайте двумерный массив. Напишите программу,
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

//дз



void SortDescending(int[,] matrix)
{
    int temp;
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int i = 0; i < matrix.GetLength(1) - 1; i++)
        {
            for (int j = i + 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[row, i] < matrix[row, j])
                {
                    temp = matrix[row, i];
                    matrix[row, i] = matrix[row, j];
                    matrix[row, j] = temp;
                }
            }
        }
    }
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




int[,] matrix = CreateMatrix(3, 4, 0, 99);
PrintMatrix(matrix);
Console.WriteLine();

SortDescending(matrix);
PrintMatrix(matrix);
