// Задача 55: Задайте двумерный массив. 
//Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести 
//сообщение для пользователя.


int[,] RotationMatrix(int[,] array)
{
    int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[j, i] = array[i, j];
        }
    }

    return newArray;
}

//***********************

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
int[,] rotationMatrix = RotationMatrix(matrix);
PrintMatrix(rotationMatrix);