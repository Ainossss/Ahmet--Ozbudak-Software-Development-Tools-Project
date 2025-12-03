using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];
        Random rnd = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(1, 100);
        }

        Console.WriteLine("Array elements (random values):");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }

        Array.Sort(numbers);

        Console.WriteLine("Array elements (sorted):");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
