//Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

//[1,0,1,1,0,1,0,0]

// эти функции будем ипользовать
int[] arr(int num)
{
    int[] myarr = new int[num];
    for (int i = 0; i < myarr.Length; i++)
    {
        myarr[i] = new Random().Next(0, 2);    //(0,1)
        //Console.Write(myarr[i])
    }
    return myarr;
}

void PrintArr(int num)
{
    int[] myarr = arr(num);
    Console.Write($"массив из {myarr.Length} символов [");
    for (int i = 0; i < myarr.Length; i++)
    {
        Console.Write($"{myarr[i]}");
        if (i < myarr.Length - 1)
            Console.Write($",");
    }
    Console.WriteLine("]");
}

PrintArr(8);