// 11. Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.

//456 -> 46
//782 -> 72
//918 -> 98

int number = new Random().Next(100, 1000); // [10, 99]
Console.WriteLine(number);

int res1 = number / 100;
int res3 = number % 10;
int finres = res1 * 10 + res3;

Console.WriteLine(finres);
