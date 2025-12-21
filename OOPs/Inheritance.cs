using System;

class Employee
{
    public void Work()
    {
        Console.WriteLine("Employee is working");
    }
}

class Manager : Employee
{
    public void Manage()
    {
        Console.WriteLine("Manager is managing");
    }
}

class Program2
{
    static void Main()
    {
        Manager m = new Manager();
        m.Work();     // Inherited
        m.Manage();   // Own
    }
}

