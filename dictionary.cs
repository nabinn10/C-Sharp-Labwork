// 24. Use a Dictionary<String, String>to store student names and emails.
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> students = new Dictionary<string, string>();

        students.Add("Ram", "ram@google.com");
        students.Add("Hari", "hari@google.com");
        students.Add("Shyam", "shyam@google.com");

        Console.WriteLine("Student names and emails:");
        foreach (KeyValuePair<string, string> entry in students)
        {
            Console.WriteLine("Name: " + entry.Key + ", Email: " + entry.Value);
        }
    }
}
