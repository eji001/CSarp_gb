// 12. Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.WriteLine("введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(num1);


Console.WriteLine("введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(num2);

if (num2 != 0)
{
    if (num1 % num2 == 0)
        Console.WriteLine("второе число кратно первому");
    else if (num1 % num2 != 0)
        Console.WriteLine("второе число не кратно первому. остаток от деления = " + num1 % num2);
}
else Console.WriteLine("деоение на 0");
