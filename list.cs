using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        // Adding elements
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(40);

        Console.WriteLine("Numbers in the list:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
