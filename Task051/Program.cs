// Задача 47: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

///дз

double[,] CreateMatrix(int rowCount, int columnCount)
{
    double[,] array = new double[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int colunm = 0; colunm < columnCount; colunm++)
        {
            array[row, colunm] = new Random().NextDouble() * 20 - 10;
        }
    }
    return array;
}

//
void PrintMatrix(double[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int colunm = 0; colunm < arr.GetLength(1); colunm++)
        {
            Console.Write($"{Math.Round(arr[row, colunm], 1)}\t");
        }
        Console.WriteLine();
    }
}

double[,] matrix = CreateMatrix(3, 4);
PrintMatrix(matrix);

