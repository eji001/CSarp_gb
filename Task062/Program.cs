// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

//??


int[,,] CreateMatrixX3(int iLength, int jLength, int kLength)
{
    int number = 11;
    int[,,] array = new int[iLength, jLength, kLength];
    for (int i = 0; i < iLength; i++)
    {
        for (int j = 0; j < jLength; j++)
        {
            for (int k = 0; k < kLength; k++)
            {
                array[i, j, k] = number;
                number++;
            }
        }
    }
    return array;
}


void PrintMatrixX3(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]} ({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.WriteLine("тестовая матрица");
int[,,] matrixX3Test = { { { 1, 2 }, { 3, 4 }, }, { { 5, 6 }, { 7, 8 }, } };
PrintMatrixX3(matrixX3Test);


Console.WriteLine("генерируемая матрица");
int[,,] matrixX3 = CreateMatrixX3(2, 2, 2);
PrintMatrixX3(matrixX3);
