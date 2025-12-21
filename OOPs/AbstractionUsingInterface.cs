using System;

interface IVehicle
{
    void Start();
}

class Bike : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Bike starts");
    }
}

class Program5
{
    static void Main()
    {
        IVehicle v = new Bike();
        v.Start();
    }
}
