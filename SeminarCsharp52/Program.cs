// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[,] arr = {
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4}
};
double sum = 0;
double row = arr.GetLength(0); // 3
double col = arr.GetLength(1); //4
double[] result = new double[4];
Console.WriteLine();
for (int i = 0; i < col; i++)
{
    for (int j = 0; j < row; j++)
    {
        sum = arr[j, i] + sum;
    }
    result[i] = Math.Round(sum / row, 1);
    sum = 0;
}
Console.WriteLine($"Среднее арифметическое каждого столбца: {result[0]}; {result[1]}; {result[2]}; {result[3]}.");


