// 11. Search an Element in an Array
using System;

class Program
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };
        Console.Write("Enter element to search: ");
        int key = Convert.ToInt32(Console.ReadLine());
        bool found = false;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == key)
            {
                Console.WriteLine("Element " + key + " found at index " + i + ".");
                found = true;
                break;
            }
        }

        if (!found)
            Console.WriteLine("Element not found in the array.");
    }
}
