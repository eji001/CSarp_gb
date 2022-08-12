//Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

double distanceBetweenPoints(double xb, double yb, double xa, double ya)
{
    return Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb - ya),2));
}

//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21
//a xa ya    xb yb
Console.WriteLine(distanceBetweenPoints(2, 1, 3, 6));
Console.WriteLine(distanceBetweenPoints(1, -1, 7, -5));
