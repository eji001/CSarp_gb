//Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// дз

int inputNumber(int m)
{
    Console.WriteLine($"введите {m} чисел разного знака");
    int numberGreatZero = 0;
    for (int i = 0; i < m; i++)
    {
        int inputZero = Convert.ToInt32(Console.ReadLine());
        if (inputZero > 0) numberGreatZero++;
    }    
    return numberGreatZero;
}


int M = 8; //количество вводимых чисел
int res = inputNumber(M);

Console.WriteLine($"Пользователь ввел {res} чисел больше 0 ");

