// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29 /// пример не коректен - должно быть 9!!!!
//!! m = 3, n = 2 -> A(m,n) = 29 !!!

int FunktionAckerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return FunktionAckerman(m - 1, 1);
    }
    else //if (m > 0 && n > 0)
    {
        return FunktionAckerman(m - 1, FunktionAckerman(m, n - 1));
    }
}

Console.WriteLine(FunktionAckerman(2, 3));//9
Console.WriteLine(FunktionAckerman(3, 2));//29

// Console.WriteLine(FunktionAckerman(1, 2));
// Console.WriteLine(FunktionAckerman(0, 1));
// Console.WriteLine(FunktionAckerman(0, 0));
// Console.WriteLine(FunktionAckerman(2, 2));
