using System;

abstract class Shape
{
    public abstract void Draw();
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}

class Program4
{
    static void Main()
    {
        Shape s = new Circle();
        s.Draw();
    }
}

