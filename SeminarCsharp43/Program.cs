// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, \
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите данные для составления функций прямых ");
Console.WriteLine("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
//для удобства я буду использовать алгоритм вычисления методом крамера ( онлайн калькулятор)
//и введу данные в таком виде: {y - 5x = 2 , y - 9x = 4} коэф для y беру "1".

double Kramer(double a, double b, double c, double d)
{
    double[] calc = { a, b, c, d };
    double result = a * (-d) - c * (-b);
    return result;
}
double Kramer2(double a, double b, double c, double d)
{
    double[] calc = { a, b, c, d };
    double result = a * d - c * b;
    return result;
}

double it = Kramer(1, k1, 1, k2);
double it1 = Kramer(b1, k1, b2, k2);
double it2 = Kramer2(1, b1, 1, b2);

double y = it1 / it;
double x = it2 / it;

Console.WriteLine($"Координаты точки пересечения :({x} , {y})");
