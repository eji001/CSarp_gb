// Задача 67: Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр.

// 453 -> 12
// 45 -> 9

int SumOfDigits(int number)
{
    if (number == 0)
        return 0;
    return (number % 10) + SumOfDigits(number / 10);
}

int res = SumOfDigits(1234);
Console.WriteLine($"{res}");
