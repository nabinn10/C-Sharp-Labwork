// 13. Find the Largest Element in a 2D Array
using System;

class Program
{
    static void Main()
    {
        int[,] arr = {
            { 3, 5, 9 },
            { 7, 1, 4 },
            { 2, 6, 8 }
        };

        int max = arr[0, 0];

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] > max)
                {
                    max = arr[i, j];
                }
            }
        }

        Console.WriteLine("Largest element in the 2D array: " + max);
    }
}
