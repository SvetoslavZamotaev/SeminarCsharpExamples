// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

int[,] arr = {
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4},
    {5,2,6,7}
};
void FindMinSumFromRow(int[,] array) // результирующий метод
{
    int[] sumRow = new int[4];
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            sumRow[i] = sumRow[i] + array[i, j];
        }
    }
    FindMinSum(sumRow);
}

void FindMinSum(int[] collect) // находит меньшее в одномерном массиве и сразу выдает строку
{
    int answer2 = 0;
    int len = collect.Length;
    int answer = collect[0];
    for (int i = 0; i < len; i++)
    {
        if (collect[i] < answer)
        {
            answer = collect[i];
            answer2 = i;
        }
    }
    Console.WriteLine($" Наименьшая суммма элементов в {answer2 + 1} строке");
}

FindMinSumFromRow(arr);




