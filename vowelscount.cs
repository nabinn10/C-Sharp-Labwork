// 4. Count the Number of Vowels in a String
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine().ToLower();
        int vowelCount = 0;

        foreach (char c in input)
        {
            if ("aeiou".IndexOf(c) >= 0)
            {
                vowelCount++;
            }
        }

        Console.WriteLine("Number of vowels in the string: " + vowelCount);
    }
}
