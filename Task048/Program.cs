// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: 
// Aₘₙ = m+n. Выведите полученный массив на экран.

// m = 3, n = 4.

// 0 1 2 3
// 1 2 3 4
// 2 3 4 5 


int[,] CreateMatrix(int rowCount, int columnCount)
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int colunm = 0; colunm < columnCount; colunm++)
        {
            array[row, colunm] = row + colunm;
        }
    }
    return array;
}


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

int[,] matrix = CreateMatrix(3, 4);
PrintMatrix(matrix);