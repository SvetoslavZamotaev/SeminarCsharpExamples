// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2



int[] arr = new int[5];

void PrintArr(int[] col)   // просто принтует массив
{
    int len = col.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write("[" + col[i] + "]");
    }
}

int[] FillArr(int[] arr, int min, int max) // заполняет массив случайными числами , с двумя параметрами мин и макс 
{
    int len = arr.Length;
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}


FillArr(arr, 100, 301);

PrintArr(arr);

int Find(int[] col)

{
    int answer = 0;
    foreach (int count in col)
    {
        if (count % 2 == 0)
        {
            answer++;
        }
    }
    return answer;
}

Console.WriteLine(" Чётных чисел - " + Find(arr));

