// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3


double[] ArithmeticMeanOfMatrixColumns(int[,] matr)
{
    double[] averageArr = new double[matr.GetLength(1)];

    for (int column = 0; column < matr.GetLength(1); column++) //мы идем по колонке
    {
        for (int row = 0; row < matr.GetLength(0); row++) //мы идем по строке
        {
            averageArr[column] += matr[row, column]; // мы добавляем в массив только то значение из матрицы что в колонке
        }
        averageArr[column] = averageArr[column] / matr.GetLength(0);// среднее по количеству строк
    }
    return averageArr;
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

//--------------
// печать массива
void PrintArray(double[] myarr)
{
    Console.WriteLine($"Среднее арифметическое каждого столбца:");
    for (int i = 0; i < myarr.Length; i++)
    {
        Console.Write($"{Math.Round(myarr[i], 2)}");
        if (i < myarr.Length - 1)
            Console.Write($"\t");
    }
}






int[,] matrix = CreateMatrix(3, 6, 0, 9);
PrintMatrix(matrix);

double[] arr = ArithmeticMeanOfMatrixColumns(matrix);
PrintArray(arr);