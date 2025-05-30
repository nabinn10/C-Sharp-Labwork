// 22. Interface IDrive and Implementation in Class Car
using System;

interface IDrive
{
    void Start();
}

class Car : IDrive
{
    public void Start()
    {
        Console.WriteLine("Car has started driving.");
    }

    static void Main()
    {
        IDrive myCar = new Car();
        myCar.Start();
    }
}
