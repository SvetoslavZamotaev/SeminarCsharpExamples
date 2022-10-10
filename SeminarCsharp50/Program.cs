// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


int[,] mainArr = { { 1, 2, 3, 4 }, { 4, 5, 6, 7 }, { 34, 65, 76, 45 }, { 23, 34, 52, 65 } };


Console.WriteLine("Введите номер элемента в массиве через пробел или запятую и программа покажет его значение");
string number = Console.ReadLine();
string[] numbers = number.Split(' ', ',');
Console.WriteLine(string.Join(' ', numbers));
int[] index = Array.ConvertAll(numbers, int.Parse);
if (index[0] > 3 || index[1] > 3) Console.WriteLine("Такого элемента нет в массиве ");
else if (index[0] < 0 || index[1] < 0) Console.WriteLine("Такого элемента нет в массиве ");
else
{
    Console.WriteLine($"Такой элемент есть: {mainArr[index[0], index[1]]}");
}
