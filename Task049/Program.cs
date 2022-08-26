// Задача 49: Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти элементы на их квадраты.
//******нечетные
//Например, изначально массив  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

//Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4



void NewMatrix(int[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int colunm = 0; colunm < arr.GetLength(1); colunm++)
        {
            if (row % 2 == 1 && colunm % 2 == 1)
            {
                arr[row, colunm] = arr[row, colunm] * arr[row, colunm];
            }
        }

    }
}
//------------
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

int[,] matrix = CreateMatrix(4, 4, 5, 9);
PrintMatrix(matrix);
Console.WriteLine();
NewMatrix(matrix);
PrintMatrix(matrix);