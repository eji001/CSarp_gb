// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

//- вставка
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

//- конец вставки

int[] CopyArray(int[] arr)
{
    int [] newArray= new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        newArray[i] = arr[i];
    }
    return newArray;
}


//вывод
int[] arr = CreateArray(10,0,9);
PrintArray(arr);

int [] CopyArr = CopyArray(arr);
PrintArray(CopyArr);

///проверка
Console.WriteLine("проверка");
CopyArr[0]= 0;
PrintArray(arr);
PrintArray(CopyArr);

