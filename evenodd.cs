// 8. Check Whether a Number is Even or Odd Using if-else
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
            Console.WriteLine(num + " is even.");
        else
            Console.WriteLine(num + " is odd.");
    }
}
