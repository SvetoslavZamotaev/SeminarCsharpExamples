int[] piska = { 1, 2, 3, 4, 5, 6, 7, 8 };
void Print(int[] array)
{
    int i = 0;
    int size = array.Length;
    while (i < size)
    {
        Console.Write(array[i] + " ");
        i++;
    }
    Console.WriteLine();
}


Print(piska);