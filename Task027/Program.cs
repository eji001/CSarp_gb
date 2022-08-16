// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.

//4 -> 24 
//5 -> 120

int Factorial(int n)
{
    int result=1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;        
    }
    return result;
}

void PrintFactorial(int n)
{
    Console.WriteLine($"произведение чисел от 1 до {n} равно {Factorial(n)}");

}

PrintFactorial(4);
PrintFactorial(5);
