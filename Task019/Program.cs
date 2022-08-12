// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
//



void Qarter(int n)
{
    if (n < 1 || n > 4) Console.WriteLine("не коректен номер четверти");
    else if (n == 1) Console.WriteLine(n + " => x > 0 && y > 0");
    else if (n == 2) Console.WriteLine(n + " => x < 0 && y > 0");
    else if (n == 3) Console.WriteLine(n + " => x < 0 && y < 0");
    else if (n == 4) Console.WriteLine(n + " => x > 0 && y < 0");
}

Qarter(5);
Qarter(4);
Qarter(3);
Qarter(2);
Qarter(1);
Qarter(0);
