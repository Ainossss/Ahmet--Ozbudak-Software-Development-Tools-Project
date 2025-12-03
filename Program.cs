using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 3, 7, 1, 9, 4 };

        Console.WriteLine("Elements of Array:");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
