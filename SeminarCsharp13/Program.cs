﻿//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
// Я очень не уверен что от меня ждали такого решения но я не смог додуматься до другого :(
Console.Clear();
Console.WriteLine("Введите число ");
string number = Console.ReadLine();

int length = number.Length;


if (length < 3)
{
    Console.WriteLine("Третьей цифры нет!,или число меньше 3 знаков длиной!");
}
else
{
    char find = number[2];
    Console.WriteLine("третье число это " + find);
}

