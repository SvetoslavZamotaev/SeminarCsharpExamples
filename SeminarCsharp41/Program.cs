// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3




Console.Write("Сколько вы хотите ввести чисел? : ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Программа укажет сколько положительных чисел вы ввели");
int answer = 0;
int count = 1;
for (int i = 0; i < num; i++)
{
    Console.Write($"Введите число : {count} ");
    int kek = Convert.ToInt32(Console.ReadLine());
    if (kek > 0) answer++;
    else if (kek == 0) answer++;
    count++;
}
Console.Write($"Ответ {answer}");