// Задача 64: Задайте значения M и N. Напишите программу,
//которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

//дз

//Задача 65:

void PrintNumbers(int M, int N)
{
    if (M > N)
        return;

    Console.Write($"{M} ");
    PrintNumbers(M + 1, N);
}

PrintNumbers(4, 8);
