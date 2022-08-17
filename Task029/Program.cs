// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Exponentiation()
{

    string ExitFlag = string.Empty;
    bool flag = true;
    int res = 1;
    while (flag)
    {
        Console.Write("введите A: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.Write("введите B: ");
        int B = Convert.ToInt32(Console.ReadLine());

        if (B > 0) // натуральеая степень 1,2,3 ... 
        {
            for (int i = 0; i < B; i++)
            {
                res *= A;
                //Console.WriteLine(res + "-" + A);
            }
            Console.WriteLine($"{A} в степени {B} == {res}");
            res = 1;
        }
        else if (B <= 0)
        {
            Console.WriteLine($"введите В > 0");
        }


        //зацикленность 
        Console.WriteLine("продолжить цикл (yes), введите y");
        ExitFlag = Convert.ToString(Console.ReadLine());
        if (ExitFlag != "y")
        {
            flag = false;
        }
    }
}

Exponentiation();
