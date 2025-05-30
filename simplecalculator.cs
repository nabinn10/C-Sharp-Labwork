// 9. Simple Calculator Using Switch Statement (Add, Sub, Mul, Div)
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        switch (op)
        {
            case "+":
                Console.WriteLine("Result: " + (num1 + num2));
                break;
            case "-":
                Console.WriteLine("Result: " + (num1 - num2));
                break;
            case "*":
                Console.WriteLine("Result: " + (num1 * num2));
                break;
            case "/":
                if (num2 != 0)
                    Console.WriteLine("Result: " + (num1 / num2));
                else
                    Console.WriteLine("Division by zero is not allowed.");
                break;
            default:
                Console.WriteLine("Invalid operator.");
                break;
        }
    }
}
