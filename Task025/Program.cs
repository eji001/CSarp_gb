//Задача 24: Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.

//7 -> 28
//4 -> 10
//8 -> 36

int Sum(int a)
{
    int result=0;
    for (int nmber = 0; nmber <=a; nmber++)
    {
        result += nmber;
    }
    return result;
}

void PrintSum(int a)
{
    Console.WriteLine($"сумма чисел от 1 до {a} равна {Sum(a)} ");
}

PrintSum(5);
PrintSum(10);
PrintSum(0);
PrintSum(-20);

/*
Console.WriteLine(Sum(5)); //1+2+3+4+5 =15
Console.WriteLine(Sum(10));
Console.WriteLine(Sum(0));
Console.WriteLine(Sum(-20));
*/