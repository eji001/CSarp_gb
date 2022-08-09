//Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int num = Convert.ToInt32(Console.ReadLine());

int res = num % 1000 / 100;
if (res == 0) Console.WriteLine("третьей цифры нет");
else Console.WriteLine(res);

