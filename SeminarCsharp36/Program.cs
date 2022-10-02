// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
double[] FillArr(double[] arr, int min, int max) // заполняет массив случайными числами , с двумя параметрами мин и макс 
{
    double len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

double[] arr = new double[5];

FillArr(arr, -9, 9);
void PrintArr(double[] col)   // просто принтует массив
{
    int len = col.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write("[" + col[i] + "]");
    }
}

PrintArr(arr);

double sum = 0;

for (int i = 0; i < 5; i++)
{
    if (i % 2 == 0)
    {
        sum = sum + arr[i];
    }
}

Console.WriteLine("сумма чисел на нечетных позициях : " + sum);




