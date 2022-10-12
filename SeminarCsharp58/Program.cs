// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:

// 2 4 | 3 4

// 3 2 | 3 3

// Результирующая матрица будет:

// 18 20

// 15 18

int[,] matrix = {
{2,4},
{3,2}
};

int[,] matrix2 = {
{3,4},
{3,3}
};

void MultiplyMatrix(int[,] matr1, int[,] matr2)
{
    int[,] resultMatr = new int[2, 2];
    resultMatr[0, 0] = matr1[0, 0] * matr2[0, 0] + matr1[0, 1] * matr2[1, 0];
    resultMatr[0, 1] = matr1[0, 0] * matr2[0, 1] + matr1[0, 1] * matr2[1, 1];
    resultMatr[1, 0] = matr1[1, 0] * matr2[0, 0] + matr1[1, 1] * matr2[1, 0];
    resultMatr[1, 1] = matr1[1, 0] * matr2[0, 1] + matr1[1, 1] * matr2[1, 1];
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            Console.Write($"({resultMatr[i, j]})");
        }
        Console.WriteLine();
    }
}

MultiplyMatrix(matrix, matrix2);
