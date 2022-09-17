//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт 
//максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Введите  число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  число B");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  число C");
int C = Convert.ToInt32(Console.ReadLine());
if (A > B && A > C)
{
    Console.WriteLine(A + " Самое большое число");
}
if (B > A && B > C)
{
    Console.WriteLine(B + " Самое большое число");
}
if (C > A && C > B)
{
    Console.WriteLine(C + " Самое большое число");
}