using System;

namespace NumberSystem;
public class Number
{
    public static bool StrongNumber(int Num)
    {
        int Temp = Num;
        int Sum = 0;
        do
        {
            int D = Num % 10;
            Sum = Sum + Factorial(D);
            Num = Num / 10;
        } while (Num != 0);

        return Temp == Sum;
    }

    public static int Factorial(int Num)
    {
        int Fact = 1;
        while (Num != 0)
        {
            Fact *= Num;
            Num--;
        }
        return Fact;
    }

    public static int BiggestDigit(int Num)
    {
        int Big = 0;
        do
        {
            int D = Num % 10;
            if (D > Big)
            {
                Big = D;
            }
            Num = Num / 10;
        } while (Num != 0);

        return Big;
    }

    public static int SmallestDigit(int Num)
    {
        int Small = Num % 10;
        Num = Num / 10;
        do
        {
            int D = Num % 10;
            if (D < Small)
            {
              Small = D;
            }
            Num = Num / 10;
        } while (Num != 0);

        return Small;
    }

    public static bool Pallindrome(int Num)
    {
        int Temp = Num;
        int Rev = 0;
        do
        {
            int D = Num % 10;
            Rev = Rev * 10 + D;
            Num = Num / 10;
        } while (Num != 0);

        return Temp == Rev;
    }

    public static void FibnaciSeries(int Num)
    {
        int F1 = 0;
        int F2 = 1;

        while(F1 <= Num)
        {
            Console.Write(F1+" ");
            int F3 = F1 + F2;
                F1 = F2;
                F2 = F3;
        }
    }
}

