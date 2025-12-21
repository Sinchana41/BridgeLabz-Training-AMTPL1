using System;

class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program3
{
    static void Main()
    {
        Animal a = new Dog();  // Runtime polymorphism
        a.Sound();
    }
}

