using System;

namespace AnanymousFunctions
{
    public delegate void MyDelegate(int A, int B);
    class Program
    {
        public static void Main()
        {
            //Anonymous Method using Delegates
            MyDelegate del = delegate (int A, int B)
            {
                Console.WriteLine("Anonymous Addition: " + (A + B));
            };

            del(10, 20);

            //Anonymous Method using Lamda Expression
            MyDelegate del1 = (X, Y) =>
            {
                Console.WriteLine("Lambda Addition: " + (X + Y));
            };

            del1.Invoke(10, 20);//30
            //1.del1.Invoke(10, 20); -> Alternate method to call
            //2.del1(10, 20);  both  are correct
        }
    }
}