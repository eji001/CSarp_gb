// Задача 46: Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.

// m = 3, n = 4.

// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


//двумерный массив 
// rowCount количество строк / columnCount количество столбцов

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