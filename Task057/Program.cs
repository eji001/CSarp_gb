//Задача 59: Задайте двумерный массив из целых чисел.
//Напишите программу, которая удалит строку и столбец,
//на пересечении которых расположен наименьший элемент массива.

//Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Наименьший элемент - 1, на выходе получим
// следующий массив:

// 9 4 2
// 2 2 6
// 3 4 7

///?
//удалять все наименьшие вхождения?

//удалить столбец (сместить)
int[,] DeleteRow(int[,] array, int row)
{
    int[,] NewArray = new int[array.GetLength(0), array.GetLength(1) - 1]; // создаем новый массив без столбца

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (j < row)
                NewArray[i, j] = array[i, j];
            else if (j >= row)
                NewArray[i, j] = array[i, j + 1];
        }
    }
    return NewArray;
}

//удалить строку(сместить)
int[,] DeleteLine(int[,] array, int line) //поменять строки местами
{
    int[,] NewArray = new int[array.GetLength(0) - 1, array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i < line)
                NewArray[i, j] = array[i, j];
            else if (i >= line)
                NewArray[i, j] = array[i + 1, j];
        }
    }
    return NewArray;
}

int[] СoordinatesMinNumberInArray(int num, int[,] arr)
{
    int[] coordinates = new int[2];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == num)
            {
                coordinates[0] = i;
                coordinates[1] = j;
            }
        }
    }

    return coordinates;
}

int MinNumber(int[,] arr)
{
    int min = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (min > arr[i, j])
                min = arr[i, j];
        }
    }
    return min;
}

/**/
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
    //случайное место 1 минимума
    array[new Random().Next(0, rowCount), new Random().Next(0, columnCount)] = -1; /////!!!!!
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
    Console.Write($"координаты [");
    for (int i = 0; i < myarr.Length; i++)
    {
        Console.Write($"{myarr[i]}");
        if (i < myarr.Length - 1)
            Console.Write($",");
    }
    Console.WriteLine("]");
}

/**/





//матрица
int[,] matrix = CreateMatrix(4, 4, 0, 9);
PrintMatrix(matrix);

//мин значение
int minNumber = MinNumber(matrix);
Console.WriteLine($"мин значение {minNumber}");

//координаты мин значения
int[] numberInArray = СoordinatesMinNumberInArray(minNumber, matrix);
PrintArray(numberInArray);

int[,] newMatrixWithoutLine = DeleteLine(matrix, numberInArray[0]);

// PrintMatrix(newMatrixWithoutLine);
Console.WriteLine();

int[,] newMatrixWithoutRow = DeleteRow(newMatrixWithoutLine, numberInArray[1]);
PrintMatrix(newMatrixWithoutRow);
