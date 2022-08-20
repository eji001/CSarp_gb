// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


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

void numberInArray(int num, int[] arr)
{
    bool flag = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) flag = true;
    }
    if (flag) { Console.WriteLine($"{num} есть в массиве"); }
    else Console.WriteLine($"{num} нет в массиве");
}

int[] arr = CreateArray(5, 0, 10);
PrintArray(arr);

numberInArray(5, arr);
numberInArray(8, arr);