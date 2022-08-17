// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]
//(пример признан некорекнтым на семинаре)

int[] NewArr(int num)
{

    if (num >= 8)
    {
        Console.WriteLine($"введено {num} ограничение на 8 ");
        num = 8;
    }

    int[] mass = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.Write($"введите значение для {i} элемента: ");
        mass[i] = Convert.ToInt32(Console.ReadLine());
    }
    return mass;
}

//копипаста
void PrintArr(int num)
{
    int[] myarr = NewArr(num);

    Console.Write($"массив из {myarr.Length} символов [");
    for (int i = 0; i < myarr.Length; i++)
    {
        Console.Write($"{myarr[i]}");
        if (i < myarr.Length - 1)
            Console.Write($",");
    }
    Console.WriteLine("]");
}


PrintArr(4);
PrintArr(9);