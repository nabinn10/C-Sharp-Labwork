using System;

namespace DelegateExample
{
    class Program
    {
        // Declare a delegate
        public delegate int Operation(int a, int b);

        // Method for addition
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        // Method for subtraction
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {
            // Instantiate the delegate with Sum method
            Operation addOperation = new Operation(Sum);

            // Instantiate the delegate with Subtract method
            Operation subtractOperation = new Operation(Subtract);

            // Get input values
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Perform addition using delegate
            int additionResult = addOperation(num1, num2);
            Console.WriteLine("Addition Result: " + additionResult);

            // Perform subtraction using delegate
            int subtractionResult = subtractOperation(num1, num2);
            Console.WriteLine("Subtraction Result: " + subtractionResult);
        }
    }
}
