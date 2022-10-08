int[] clocks = new int[12];
int len = clocks.Length;
for (int i = 0; i < len; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine("Введите час входа посетителя " + (i + 1));
        int enter = Convert.ToInt32(Console.ReadLine());
        clocks[i] = enter;
    }
    else
    {
        Console.WriteLine("Введите час выхода посетителя " + (i + 1));
        int leave = Convert.ToInt32(Console.ReadLine());
        clocks[i] = leave;
    }
}

Array.Sort(clocks);
Console.Write(string.Join(' ', clocks));

Console.WriteLine();
int CountNum(int[] col, int number)
{
    int count = 0;
    int len = col.Length;
    for (int i = 0; i < len; i++)
    {
        if (col[i] == number)
        {
            count++;
        }
    }
    return count;
}


int[] results = new int[12];
for (int i = 0; i < len; i++)
{
    results[i] = CountNum(clocks, clocks[i]);
}
Console.Write(string.Join(' ', results));
int max = 0;
for (int i = 0; i < len; i++)
{
    if (results[i] > max)
    {
        max = results[i];
    }
}
int hour = Array.IndexOf(results, max);


Console.WriteLine();
Console.WriteLine(" Самое большое колличество посетителей было в " + clocks[hour] + " часов");
