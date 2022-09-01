// Задача 58: Задайте две матрицы.
//'Напишите программу, которая будет находить произведение двух матриц.

//??

bool MatrixCompatibillity(int[,] A, int[,] B)
{
    //проверяем совместимость матриц. (можно ли их перемножить)
    bool matrixCompatibillity = A.GetLength(1) == B.GetLength(0);

    if (matrixCompatibillity)
        Console.WriteLine("умножить матрицы можно");
    else
        Console.WriteLine("умножить матрицы нельзя");

    return matrixCompatibillity;
}

int[,] MatrixProduct(int[,] A, int[,] B)
{
    int[,] matrixProduct = new int[A.GetLength(0), B.GetLength(1)];

    for (int i = 0; i < A.GetLength(0); i++) //2
    {
        for (int j = 0; j < B.GetLength(1); j++) //3
        {
            for (int k = 0; k < A.GetLength(1); k++)
            {
                matrixProduct[i, j] += A[i, k] * B[k, j];
            }
        }
    }

    return matrixProduct;
}

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

//размеры матриц

/* расчет тестового примера

int[,] matrixA = { { 1, 2 }, { 3, 4 }, };
PrintMatrix(matrixA);
Console.WriteLine();

// можно перемножить
int[,] matrixB = { { 5, 6, 7 }, { 8, 9, 10 }, };
// нельзя перемножить
// int[,] matrixB = { { 5, 6, 7 }, { 8, 9, 10 }, { 8, 9, 10 }, }; 
PrintMatrix(matrixB);
Console.WriteLine();

int[,] matrixAB = { { 21, 24, 27 }, { 47, 54, 61 }, };
PrintMatrix(matrixAB);
Console.WriteLine();
*/


int coordM = 2;

int[,] matrixA = CreateMatrix(3, coordM, 0, 9);
PrintMatrix(matrixA);
Console.WriteLine();

int[,] matrixB = CreateMatrix(coordM, 4, 0, 9);
PrintMatrix(matrixB);
Console.WriteLine();



if (MatrixCompatibillity(matrixA, matrixB)) // условие проверки на умножение
{
    int[,] matrixProduct = MatrixProduct(matrixA, matrixB);
    PrintMatrix(matrixProduct);
    Console.WriteLine();
}
