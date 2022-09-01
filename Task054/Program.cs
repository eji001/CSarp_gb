// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

void SwapRows(int[,] array)
{
    int rowCount = array.GetLength(0);
    for (int i = 0; i < array.GetLength(1); i++) // количество столбцов
    {
        //array[0,i] <-> array[rowCount-1]
        int temp = array[0, i];
        array[0, i] = array[rowCount - 1, i];
        array[rowCount - 1, i] = temp;

    }
}

//*************
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
SwapRows(matrix);
PrintMatrix(matrix);
