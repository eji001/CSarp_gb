//16. Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.


// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.WriteLine("введите 1 число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите 2 число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2 || num2 == num1 * num1)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

