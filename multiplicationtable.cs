// 7. Generate a Multiplication Table for a Given Number

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number to generate its multiplication table: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Multiplication Table of " + num + ":");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(num + " x " + i + " = " + (num * i));
        }
    }
}
