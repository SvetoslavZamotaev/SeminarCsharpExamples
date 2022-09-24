void Palindrome(int num1, int num2, int num3, int num4, int num5)

{
    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine("Это число палиндром!");
    }
    else
    {
        Console.WriteLine("Это число не палиндром!");
    }
}
Palindrome(6, 7, 5, 7, 8);