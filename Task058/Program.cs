// Задача 61: Вывести первые N строк треугольника Паскаля.
//Сделать вывод в виде равнобедренного треугольника

//??

int Factorial(int n)
{
    int res = 1;
    for (int i = 1; i <= n; i++)
    {
        res *= i;
    }
    return res;
}

int ElementCalculationPascalTriangle(int i, int c)
{
    int res = Factorial(i) / (Factorial(c) * Factorial(i - c));

    return res;
}

void PrintPascalTriangle(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int c = 0; c <= (n - i); c++) // создаём после каждой строки n-i отступов от левой стороны консоли, чем ниже строка, тем меньше отсутп
        {
            Console.Write("   ");
        }
        for (int c = 0; c <= i; c++)
        {
            int res = ElementCalculationPascalTriangle(i, c);
            string space = "     ";

            if (res >= 10)
                space = "    ";
            if (res >= 100)
                space = "   ";

            Console.Write(space); // создаём пробелы между элементами треугольника
            Console.Write(res);
        }
        Console.WriteLine();
        Console.WriteLine(); // после каждой строки с числами отступаем две пустые строчки
    }
}

PrintPascalTriangle(6);
