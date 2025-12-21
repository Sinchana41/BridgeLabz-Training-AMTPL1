using System;

namespace NumberSystem;

class NumberMain
{
    public static void Main()
    {  
        Console.WriteLine("Enter the Number : ");
        int Num = Convert.ToInt32(Console.ReadLine());

        bool Result1 = Number.StrongNumber(Num);
        if (Result1)
        {
            Console.WriteLine("{0} is a Strong Number", Num);
        }
        else
        {
            Console.WriteLine("{0} is a not Strong Number", Num);
        }
        Console.WriteLine("------------------------------");


        int Result2 = Number.BiggestDigit(Num);
        Console.WriteLine("{0} is a biggest digit in {1}",Result2, Num);
        Console.WriteLine("------------------------------");

        int Result3 = Number.SmallestDigit(Num);
        Console.WriteLine("{0} is a smallest digit in {1}", Result3, Num);
        Console.WriteLine("------------------------------");

        bool Result4 = Number.Pallindrome(Num);
        if (Result4)
        {
            Console.WriteLine("{0} is a Pallindrome Number", Num);
        }
        else
        {
            Console.WriteLine("{0} is a not Pallindrome Number", Num);
        }
        Console.WriteLine("------------------------------");

        Number.FibnaciSeries(Num);
    }
}