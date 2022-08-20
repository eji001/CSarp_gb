//32 



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

//вывод
int[] arr = CreateArray(12,-9,9);
PrintArray(arr);

//Console.WriteLine($" {}");
//Console.WriteLine($" {(arr)}");