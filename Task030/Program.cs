// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12 

int SumOfNumber(int n)
{
    int summ = 0;
    while (n > 0)
    {
        summ += n % 10;
        n /= 10;
    }

    return summ;
}

void PrintSumOfNumber(int num)
{
    Console.WriteLine($"суммф чисел в чмсле {num} равна {SumOfNumber(num)}");
}

PrintSumOfNumber(452);
PrintSumOfNumber(82);
PrintSumOfNumber(9012);