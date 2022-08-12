// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double distanceBetweenPoints(double xb, double yb, double zb, double xa, double ya, double za )
{
    return Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb - ya),2) + Math.Pow((zb - za),2));
}

// A (7,-5, 0); B (1,-1, 9) -> 11.53
//a  xa ya za     xb yb zb
Console.WriteLine(distanceBetweenPoints(7, -5, 0, 1, -1, 9));
Console.WriteLine(distanceBetweenPoints(3, 6, 8, 2, 1, -7));

