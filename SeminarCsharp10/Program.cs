Console.Clear();
Console.WriteLine("Введите трёхзначное целое число ");
int number = Convert.ToInt32(Console.ReadLine());
number = (number / 10) % 10;
Console.WriteLine("вторая цифра введенного числа равна : " + number);
