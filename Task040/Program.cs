//Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


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

void ReversArray(int[] arr)
{
    int r=0;
    for (int i = 0; i < arr.Length/2; i++)
    {
        //arr[i]
        int temp = arr[i];
        arr[i]= arr[arr.Length-i-1];
        arr[arr.Length-i-1] = temp;

    }
}

//вывод
int[] arr = CreateArray(10,-5,10);
PrintArray(arr);

ReversArray(arr);
PrintArray(arr);

//Console.WriteLine($" {}");
//Console.WriteLine($" {(arr)}");