// 21. Abstract Class Shape with Inherited Classes Circle and Rectangle
using System;

abstract class Shape
{
    public abstract double Area();
}

class Circle : Shape
{
    public double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Length, Width;

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double Area()
    {
        return Length * Width;
    }

    static void Main()
    {
        Shape c = new Circle(5);
        Console.WriteLine("Area of Circle: " + c.Area());

        Shape r = new Rectangle(4, 6);
        Console.WriteLine("Area of Rectangle: " + r.Area());
    }
}
