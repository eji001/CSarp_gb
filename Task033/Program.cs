// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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

int[] ChangeSign(int[] arr)
{
    int[] newArr = arr;
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = newArr[i] * -1;
    }
    return newArr;
}

int[] arr = CreateArray(4, -9, 9);
PrintArray(arr);

int[] newarr = ChangeSign(arr);
PrintArray(newarr);