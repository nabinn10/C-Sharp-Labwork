// 20. Method Overloading with Add(int, int) and Add(float, float)
using System;

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public float Add(float a, float b)
    {
        return a + b;
    }

    static void Main()
    {
        Calculator calc = new Calculator();
        Console.WriteLine("Int Add: " + calc.Add(5, 7));
        Console.WriteLine("Float Add: " + calc.Add(5.5f, 2.3f));
    }
}
