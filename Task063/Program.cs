// Задача 62: Заполните спирально массив 4 на 4.

// 1  2  3  4
// 12 13 14 5
// 11 16 15 6
// 10  9  8 7

//??


int[,] SpiralMatrix(int n)
{
    int[,] array = new int[n, n];

    int num = 1;
    int value = -n;//
    int sum = -1;//

    for (int count = n; count > 0; )
    {
        value = -1 * value / n;//
        for (int i = 0; i < count; i++)
        {
            sum += value;
            array[sum / n, sum % n] = num++;//
        }
        value *= n;//
        count--;
        for (int i = 0; i < count; i++)
        {
            sum += value;//
            array[sum / n, sum % n] = num++;//
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



int[,] matrix = SpiralMatrix(4);
PrintMatrix(matrix);
Console.WriteLine();
