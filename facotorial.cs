// 5. Write a program to find the factorial of a number using a for loop.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number to find factorial: ");
        int num = Convert.ToInt32(Console.ReadLine());
        long factorial = 1;

        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("Factorial of " + num + " is " + factorial);
    }
}

