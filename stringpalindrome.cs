// 14. Check if a String is a Palindrome
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string original = Console.ReadLine();
        string reversed = "";

        for (int i = original.Length - 1; i >= 0; i--)
        {
            reversed += original[i];
        }

        if (original.Equals(reversed, StringComparison.OrdinalIgnoreCase))
            Console.WriteLine("The string is a palindrome.");
        else
            Console.WriteLine("The string is not a palindrome.");
    }
}
