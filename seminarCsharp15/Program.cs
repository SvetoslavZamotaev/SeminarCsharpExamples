string[] week = { "нет такого дня!", "нет не ", "нет не ", "нет не ", "нет не ", "нет не ", "Да!,", "да!," };
int day;
int index = 0;
Console.WriteLine("Привет! Программа ответит на вопрос выходной ли это?");

while (index < 7)
{
    Console.WriteLine("Введи порядковый номер дня недели если 1 это понедельник!");
    day = Convert.ToInt32(Console.ReadLine());
    if (day != 0)
    {
        Console.WriteLine(week[day] + " выходной!");
    }
    else
    {
        Console.WriteLine(week[0]);
    }
    index++;
}