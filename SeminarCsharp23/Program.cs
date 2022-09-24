//Задача 23

//Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

void Cubes(int n)
{
    double[] array = new double[n];
    int index = 0;
    n = array.Length;
    double count = 1;
    while (index < n)
    {
        array[index] = Math.Pow(count, n);
        index++;
        count++;
    }
    index = 0;
    while (index < n)
    {
        Console.Write(array[index] + " ");
        index++;
    }

}
Cubes(3);
// ЭТО ТАКОЙ КАЙФ КОГДА РАБОТАЕТ!!!!!!!!моя проблема была что я не учел реальный смысл void!!!
// как только я использовал void я смог наконец возвращать сообщение консоли из метода!!