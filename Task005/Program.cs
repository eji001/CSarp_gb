//Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.
//  456 -> 6	
//  782 -> 2	
//  918 -> 8

Console.WriteLine("введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if(number<1000 && number>99){
    Console.WriteLine("последняя цифра "+number+" это: "+number%10);
} else {
    Console.WriteLine("введено НЕ трехзначное число");
}

