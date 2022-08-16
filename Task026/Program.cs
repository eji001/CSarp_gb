// Задача 26: Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.

//456 -> 3
//78 -> 2
//89126 -> 5

int NumDigetsInNumber(int number)
{
    int Result =0;
    for(;number>0;)
    {
        number /=10;
        Result ++;
    }
    return Result;
}

void PrintNumberInNumber(int num)
{
    Console.WriteLine($"Число {num} слдержит {NumDigetsInNumber(num)} чисел");
}

PrintNumberInNumber(456);
PrintNumberInNumber(78);
PrintNumberInNumber(89126);
PrintNumberInNumber(4056);
