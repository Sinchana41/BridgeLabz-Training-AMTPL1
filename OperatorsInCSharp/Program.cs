using System;

class Airthematic
{
   static int X = 100;
   static int Y = 200;
   static int Z = 300;

    int A = 10;
    int B = 20;
    int C = 30;

    public static void Main(string[] args)
    {
        Airthematic airthematic = new Airthematic();
        Console.WriteLine("First value - {0}", airthematic.A);//10
        Console.WriteLine("Second value - {0}", airthematic.B);//20
        Console.WriteLine("Third value - {0}", airthematic.C);//30
        Console.WriteLine("Addition - {0}", (airthematic.A + airthematic.B + airthematic.C));//60
        Console.WriteLine("Subtraction - {0}", (airthematic.A - airthematic.B - airthematic.C));//-40
        Console.WriteLine("Multiplication - {0}", (airthematic.A * airthematic.B * airthematic.C));//6000
        Console.WriteLine("Division - {0}", (airthematic.C / airthematic.A));//3
        Console.WriteLine("Modulus - {0}", (airthematic.A % airthematic.B));//10

        Console.WriteLine("-------------------------------------------------------------");

        Console.WriteLine("First value - {0}", X);//100
        Console.WriteLine("Second value - {0}", Y);//200
        Console.WriteLine("Third value - {0}",Z);//300
        Console.WriteLine("Addition - {0}", (X + Y + Z));//600
        Console.WriteLine("Subtraction - {0}", (X - Y - Z));//-400
        Console.WriteLine("Multiplication - {0}", (X * Y * Z));//6000000
        Console.WriteLine("Division - {0}", (Z / X));//3
        Console.WriteLine("Modulus - {0}", (X % Y));//100
    }
}