// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
//      y = k1 * x + b1, 
//      y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, 
// k1 = 5, 
// b2 = 4, 
// k2 = 9 
//      -> (-0,5; -0,5)


void pointOfIntersection(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * (b2 - b1) / (k1 - k2) + b2;    
    
    Console.WriteLine($"({x}; {y}) - точка пересечения y={k1}*x+{b1} и y={k2}*x+{b2}");
}


//===========
double b1 = 21;
double k1 = 5;
double b2 = 4;
double k2 = 9;

pointOfIntersection(b1, k1, b2, k2);
