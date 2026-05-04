using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 3, 3, 4, 5, 5, 7 };

        int uniqueOddCount = CountUniqueOddNumbers(numbers);

        Console.WriteLine($"Unique odd numbers: {uniqueOddCount}");
    }

    public static int CountUniqueOddNumbers(int[] numbers)
    {
        if (numbers == null)
        {
            throw new ArgumentNullException(nameof(numbers), "The array should not be null.");
        }

        HashSet<int> uniqueOddNumbers = new HashSet<int>();

        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                uniqueOddNumbers.Add(number);
            }
        }

        return uniqueOddNumbers.Count;
    }
}
