// 16. Method Using ref and out Parameters
using System;

class Program
{
    static void ModifyNumbers(ref int x, out int y)
    {
        x += 10;
        y = x * 2;
    }

    static void Main()
    {
        int a = 5;
        int b; // Must be assigned inside the method

        ModifyNumbers(ref a, out b);

        Console.WriteLine("After method call:");
        Console.WriteLine("a (ref) = " + a);
        Console.WriteLine("b (out) = " + b);
    }
}
