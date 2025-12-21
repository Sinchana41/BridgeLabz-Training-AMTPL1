using System;
class NumberIf
{
    public static void Main()
    {
        Console.WriteLine("Enter the number");
        int X = Convert.ToInt32(Console.ReadLine());

        string result = "Positive";
        if (X < 0)
        {
            result = "Negative";
        }
        Console.WriteLine("The Entered number is {0}", result);
        Console.WriteLine("--------------------------------------------------------");

        if (X <= 0)
        {
            X = X * -1;
            Console.WriteLine("Entered number is converted into positive : {0}", X);
            Console.WriteLine("--------------------------------------------------------");
        }


        Console.WriteLine("Enter the second number");
        int Y = Convert.ToInt32(Console.ReadLine());

        int Big = X;
        if (Y > Big)
        {
            Big = Y;
        }
        Console.WriteLine("The bigger number between {0},{1} is {2}", X, Y, Big);
        Console.WriteLine("--------------------------------------------------------");

        int Small = X;
        if (Y < Small)
        {
            Small = Y;
        }
        Console.WriteLine("The smaller number between {0},{1} is {2}", X, Y, Small);
        Console.WriteLine("--------------------------------------------------------");

        string EqualOrNot = "Equal";
        if (X != Y)
        {
            EqualOrNot = "Not Equal";
        }
        Console.WriteLine("Two numbers are {0}", EqualOrNot);
        Console.WriteLine("--------------------------------------------------------");

        NumberIfElse.NumberCheck();
    }
}