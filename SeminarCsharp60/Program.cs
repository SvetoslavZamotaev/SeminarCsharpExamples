// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2

// 66(0,0,0) 25(0,1,0)

// 34(1,0,0) 41(1,1,0)

// 27(0,0,1) 90(0,1,1)

// 26(1,0,1) 55(1,1,1)

int[,,] threeDim = {
    {
        {0,0},
        {0,0}
    },

    {
        {0,0},
        {0,0}
    }
};


for (int z = 0; z < threeDim.GetLength(0); z++)
{
    for (int i = 0; i < threeDim.GetLength(1); i++)
    {
        for (int j = 0; j < threeDim.GetLength(2); j++)
        {
            threeDim[z, i, j] = new Random().Next(11, 99);
            Console.Write($"{threeDim[z, i, j]} => ({z};{i};{j}) ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine();
}