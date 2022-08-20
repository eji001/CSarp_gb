//Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// в дз !!!

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


int[] ProductOfPairsOfNumbers(int[] arr)
{

    //размер нового массива
    int length = 0;
    if (arr.Length % 2 == 1) length = arr.Length / 2 + 1;
    else length = arr.Length / 2;
    //Console.WriteLine(length);

    int[] newarr = new int[length];

    for (int i = 0; i < length; i++)
    {
        if (i != arr.Length - 1 - i) //тк в примере не перемножаем центральное число в массиве само на себя
            newarr[i] = arr[i] * arr[arr.Length - 1 - i]; // !!! (-1) !!
        else newarr[i] = arr[i];

    }

    return newarr;
}
//вывод
int[] arr = CreateArray(6, 0, 4);
PrintArray(arr);

int[] newArr = ProductOfPairsOfNumbers(arr);
PrintArray(newArr);
//Console.WriteLine($" {}");