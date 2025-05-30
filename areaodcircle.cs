
// 1. Calculate the Area of a Circle
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * radius * radius;
        Console.WriteLine("Area of the circle = " + area);
    }
}
