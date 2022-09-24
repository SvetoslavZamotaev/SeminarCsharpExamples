//Напишите метод, который принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53
//Math.Sqrt(Double)
//Math.Pow(g, c);

double DistanceBetweenDots(double ax, double ay, double az, double bx, double by, double bz)
{
    double distance = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2));
    return Math.Round(distance, 2);
}


Console.WriteLine(DistanceBetweenDots(3, 6, 8, 2, 1, -7) + " Вот и ответ подъехал!");
Console.WriteLine(DistanceBetweenDots(7, -5, 0, 1, -1, 9) + " Вот и ответ подъехал!");