// 19. Multilevel Inheritance Example
using System;

// Base class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal eats food.");
    }
}

// Derived from Animal
class Mammal : Animal
{
    public void Walk()
    {
        Console.WriteLine("Mammal walks.");
    }
}

// Derived from Mammal
class Dog : Mammal
{
    public void Bark()
    {
        Console.WriteLine("Dog barks.");
    }

    static void Main()
    {
        Dog d = new Dog();
        d.Eat();
        d.Walk();
        d.Bark();
    }
}
