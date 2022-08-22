//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.

// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void Fibonacci(int num)
{
    Console.Write($"Если N = {num} -> ");

    int[] arr = new int[num];

    arr[0] = 0;
    arr[1] = 1;

    if (num >= 2)
    {
        for (int i =2 ; i < num; i++)        
        {
            arr[i]=arr[i-1]+arr[i-2];
        }
    }

    for (int i = 0; i < num; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
//Console.WriteLine("// Если N = 7 -> 0 1 1 2 3 5 8");

Fibonacci(7);