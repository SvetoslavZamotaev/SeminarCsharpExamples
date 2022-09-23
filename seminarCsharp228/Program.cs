Console.Clear();
Console.WriteLine("Добрый день! введите последовательно 7 цифр , программа вычислит среднее арифметическое");
int[] numbers = new int[7];
int index = 0;
int count = 1;
int answer = 0;
while (index < 7)
{
    Console.WriteLine("Введите число " + count);
    numbers[index] = Convert.ToInt32(Console.ReadLine());
    index++;
    count++;
}
answer = (numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] + numbers[5] + numbers[6]) / numbers.Length;
Console.WriteLine("Ответ " + answer);



