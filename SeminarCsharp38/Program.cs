// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] MakeEmpty(int length) //выдает инт массив с нулями с параметром длина массива
{
    double[] col = new double[length];
    return col;
}


void PrintArr(double[] col)   // просто принтует массив
{
    int len = col.Length;
    for (int i = 0; i < len; i++)
    {
        Console.WriteLine("[" + col[i] + "]");
    }
}


double[] FillArr(double[] arr, int min, int max) // заполняет массив случайными числами , 
{
    double len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max) + Math.Round(new Random().NextDouble(), 1); // создали сумму целое число+ десятичное с 2мя знаками после нуля
    }
    return arr;
}


double[] numbers = MakeEmpty(8);

FillArr(numbers, -9, 9);

PrintArr(numbers);

int len = numbers.Length;
double min = numbers[0];
double max = 0;
for (int i = 0; i < len; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}
Console.WriteLine("это самое большое число " + max);
for (int i = 1; i < len; i++)
{

    if (min > numbers[i])
    {
        min = numbers[i];
    }
}
Console.WriteLine("это самое маленькое число " + min);
double result = max - min;
Console.WriteLine("разница между max и min = " + result);

