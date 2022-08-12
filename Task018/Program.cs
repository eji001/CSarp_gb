//17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.


//найти четверть
int FindQarter(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    else if (x < 0 && y > 0)
        return 2;
    else if (x < 0 && y < 0)
        return 3;
    else if (x > 0 && y < 0)
        return 4;

    return 0;
}

//найти четверть
void FindQarter1(int x, int y)
{
    if (x > 0 && y > 0)
        Console.WriteLine("1 четверть");

    else if (x < 0 && y > 0)
        Console.WriteLine("2 четверть");
    else if (x < 0 && y < 0)
        Console.WriteLine("3 четверть");
    else if (x > 0 && y < 0)
        Console.WriteLine("4 четверть");
    else
        Console.WriteLine("ввод некоректен");
}

Console.WriteLine(FindQarter(4, 7));
Console.WriteLine(FindQarter(-19, 7));
Console.WriteLine(FindQarter(-5, -3));
Console.WriteLine(FindQarter(4, -8));
Console.WriteLine(FindQarter(4, 0));

FindQarter1(4, 7);
FindQarter1(-19, 7);
FindQarter1(-5, -3);
FindQarter1(4, -8);
FindQarter1(4, 0);