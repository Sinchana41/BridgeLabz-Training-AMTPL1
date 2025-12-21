using System;

public class NumberIfElse
{
    public static void NumberCheck()
    {
        Console.WriteLine("Enter the number");
        int X = Convert.ToInt32(Console.ReadLine());

        if (X >= -9 && X <= 9)
        {
            Console.WriteLine("Entered number is Digit");
        }
        else
        {
            Console.WriteLine("Entered number is Not a Digit");
        }
        Console.WriteLine("--------------------------------------------------------");


        if (X > 0)
        {
            Console.WriteLine("The Entered number is positive");
        }
        else
        {
             Console.WriteLine("The Entered number is Negative");
             Console.WriteLine("--------------------------------------------------------");
             X = X * -1;
             Console.WriteLine("Entered number is converted into positive : {0}", X);
        }
        Console.WriteLine("--------------------------------------------------------");

        if (X % 2 == 0)
        {
            Console.WriteLine("Entered number is Even Number");
        }
        else
        {
            Console.WriteLine("Entered number is Even Number");
        }
        Console.WriteLine("--------------------------------------------------------");


        Console.WriteLine("Enter the second number");
        int Y = Convert.ToInt32(Console.ReadLine());

        if ((Y / 2) * 2 == Y)
        {
            Console.WriteLine("Entered number is Even Number");
        }
        else
        {
            Console.WriteLine("Entered number is Even Number");
        }
        Console.WriteLine("--------------------------------------------------------");


        if (X > Y)
        {
            Console.WriteLine("The bigger number between {0},{1} is {2}", X, Y, X);
        }
        else
        {
            Console.WriteLine("The bigger number between {0},{1} is {2}", X, Y, Y);
        }
        Console.WriteLine("--------------------------------------------------------");

        
        if (X != Y)
        {
            Console.WriteLine("Two numbers are not Equal");
        }
        else
        {
            Console.WriteLine("Two numbers are Equal");
        }
        Console.WriteLine("--------------------------------------------------------");
    }
}
