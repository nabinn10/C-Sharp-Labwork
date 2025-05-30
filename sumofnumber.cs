// 15. Method That Returns the Sum of Two Numbers
using System;

class Program
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int y = Convert.ToInt32(Console.ReadLine());

        int result = Add(x, y);
        Console.WriteLine("Sum = " + result);
    }
}
