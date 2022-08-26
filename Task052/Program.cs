// Задача 50: Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет


void CheckingElementMatrix(int row, int column, int[,] arr)
{
    if (row >= arr.GetLength(0) || column >= arr.GetLength(1))
    {
        Console.WriteLine($"(считаем с нуля) на позиции ({row} : {column}) Элемента нет ");
    }
    else
    {
        Console.WriteLine($"(считаем с нуля) на позиции ({row} : {column}) Элемент {arr[row, column]}");
    }
}

////***************************
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

int[,] matrix = CreateMatrix(3, 4, 0, 9);
PrintMatrix(matrix);


CheckingElementMatrix(2,2,matrix);
CheckingElementMatrix(3,5,matrix);
