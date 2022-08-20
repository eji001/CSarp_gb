//Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

/// вещественные - (.. -2 -1 0 1 2 ..)

// инициализация массива
// min- включается , max - не включается
int[] CreateArray(int length, int min , int max)
{
    int[] myarr = new int[length];
    for (int i = 0; i < myarr.Length; i++)
    {
        myarr[i] = new Random().Next(min, max+1);    // (min, max+1) 
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

int MinNumber(int[] arr)
{
    int min=arr[0];
    for (int i = 0; i < arr.Length; i++)    
    {
        if (min>arr[i]) min= arr[i];        
    }
    return min;
}

int MaxNumber(int[] arr)
{
    int max=arr[0];
    for (int i = 0; i < arr.Length; i++)    
    {
        if (max<arr[i]) max= arr[i];        
    }
    return max;
}

//вывод
int[] arr = CreateArray(6,-9,9);
PrintArray(arr);

//Console.WriteLine($" {}");
Console.WriteLine($"разница между максимальным {MaxNumber(arr)} и минимальным {MinNumber(arr)} элементами массива равна {MaxNumber(arr) - MinNumber(arr)}");
