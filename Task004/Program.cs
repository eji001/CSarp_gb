//Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("введите целое положительне число: ");
int number= Convert.ToInt32(Console.ReadLine());
int i;
if(number<=0) {Console.WriteLine("число некорекно - введите положительное");
}else{

    for(i=(-1)*number; i<=number;i++){
        Console.Write(i+" ");

    }
}