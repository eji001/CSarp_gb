// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0



// инициализация массива
// min- включается , max - не включается
int[] CreateArray(int length, int min, int max)
{
    int[] myarr = new int[length];
    for (int i = 0; i < myarr.Length; i++)
    {
        myarr[i] = new Random().Next(min, max + 1);    // (min, max+1) 
    }
    return myarr;
}

// печать массива
void PrintArray(int[] myarr)
{
    Console.Write($"массив из {myarr.Length} символов [");
    for (int i = 0; i < myarr.Length; i++)
    {
        Console.Write($"{myarr[i]}");
        if (i < myarr.Length - 1)
            Console.Write($",");
    }
    Console.WriteLine("]");
}

int SumOfElementsAtOddPosition(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}


//вывод
int[] arr = CreateArray(6, 0, 9);
PrintArray(arr);

//Console.WriteLine($" {}");
Console.WriteLine($"сумма элементов на нечетных позициях {SumOfElementsAtOddPosition(arr)}");