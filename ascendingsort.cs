// 10. Sort an Array in Ascending Order
using System;

class Program
{
    static void Main()
    {
        int[] arr = { 5, 2, 8, 1, 3 };
        int temp;

        // Sorting using simple Bubble Sort
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Sorted array in ascending order:");
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
    }
}
