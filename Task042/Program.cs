//Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.

// 45 -> 101101
// 3  -> 11
// 2  -> 10

int numberSize(int num)
{
    //размер массива
    //Console.WriteLine($"{num}");
    int length = 0;
    int numLength = num;
    while (numLength != 0)
    {
        numLength /= 2;
        length++;
    }
    Console.WriteLine($"размер числа {num} в двоичной системе исчисления: {length}");
    return length;
}

void convert10to2(int num)
{
    int length = numberSize(num); //размер числа в двоичной системе исчисления    
    int[] arrToConvert = new int[length];
    int num1 = num;

    for (int i = 0; i < arrToConvert.Length; i++)
    {
        num1 = num % 2;
        num = num / 2;
        arrToConvert[i] = num1;
        //Console.Write($"{num1}");
    }

    ReversArray(arrToConvert); //обратиь массив
    PrintArray(arrToConvert); // печать массива
    Console.WriteLine();
}

///===========================
void PrintArray(int[] myarr)
{
    for (int i = 0; i < myarr.Length; i++)
    {
        Console.Write($"{myarr[i]}");
    }
}

void ReversArray(int[] arr)
{
    int r = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - i - 1];
        arr[arr.Length - i - 1] = temp;
    }
}
///===========================


Console.WriteLine("// 2  -> 10");
convert10to2(2);

Console.WriteLine("// 45 -> 101101");
convert10to2(45);