using System;

namespace DelegatesPrograms
{
    public delegate void AddDelegate(int a, int b);

    class Program
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine("Addition : "+(x + y));
        }

        public static void Sub(int x, int y)
        {
            Console.WriteLine("Subtraction : "+(x - y));
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static bool Modulus(int x)
        {
            return x % 10 == 0;
        }

        public static void Main()
        {
            AddDelegate ad = Add;
            ad += Sub;
            ad(10, 5);

            Action<int, int> ad1 = Add;
            ad1 += Sub;
            ad1(10,9);

            Func<int, int, int> ad2 = Multiply;
            Console.WriteLine("Multiplication : "+ (ad2(30, 2)));

            Predicate<int> ad3 = Modulus;
            Console.WriteLine("Modulus by 10 : "+ (ad3(30)));
        }
    }
}