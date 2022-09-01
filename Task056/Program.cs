// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

//** ремарка
//сказано что для одномерных и двумерных !!- для трех менрых непросили
/**/
//Набор данных
//{ 1, 9, 9, 0, 2, 8, 0, 9 }

//Частотный массив
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// Набор данных
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// Частотный массив
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
/**/

void FrequencyDictionary(int[] arr)
{
    int flag = arr[0];
    int count = 1;
    int max = 1;

    for (int i = 1; i < arr.Length; i++)
    {
        if (flag == arr[i])
        {
            count++;
            max++;
        }
        else if (flag != arr[i])
        {
            Console.WriteLine($"{flag} встречается {count} раза ");
            flag = arr[i];
            count = 1;
            max++;
        }
        if (max > arr.Length - 1)
            Console.WriteLine($"{flag} встречается {count} раза ");
    }
}

void SortArray(int[] arr)
{
    Array.Sort(arr);
}

int[] ConwertMatrixToArray(int[,] matrix)
{
    int matrixSize = (matrix.GetLength(0)) * (matrix.GetLength(1)); //размер матрицы
    int[] arr = new int[(matrixSize)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[j + i * (matrix.GetLength(1))] = matrix[i, j];
            // Console.WriteLine(j+i*(matrix.GetLength(1))); //перевод координат из массива в матрицу
        }
    }
    return arr;
}

//************************* одномерный массив
int[] CreateArray(int length, int min, int max)
{
    int[] myarr = new int[length];
    for (int i = 0; i < myarr.Length; i++)
    {
        myarr[i] = new Random().Next(min, max + 1); // (min, max+1)
    }
    return myarr;
}
void PrintArray(int[] myarr)
{
    for (int i = 0; i < myarr.Length; i++)
    {
        Console.Write($"{myarr[i]}\t");
    }
    Console.WriteLine();
    Console.WriteLine();
}

//************************* двумерный сассив
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
    Console.WriteLine();
}

//вывод


int[,] matrix = CreateMatrix(3, 5, 0, 9); //создать матрицу
PrintMatrix(matrix); // печать матрицы

int[] array = ConwertMatrixToArray(matrix);
PrintArray(array); //печать массива

SortArray(array);
PrintArray(array); //печать массива

FrequencyDictionary(array);
