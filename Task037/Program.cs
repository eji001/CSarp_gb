//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2



// инициализация массива
int[] CreateArray(int length, int min, int max)
{
    int[] myarr = new int[length];
    for (int i = 0; i < myarr.Length; i++)
    {
        myarr[i] = new Random().Next(min, max + 1);    //(-9,10)       (min, max+1) 
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

int EwentNumberInArray(int[] arr)
{
    int num = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) num++;
    }
    return num;
}

//вывод
int[] arr = CreateArray(6, 100, 999);
PrintArray(arr);

Console.WriteLine($"четных чисел {EwentNumberInArray(arr)}");