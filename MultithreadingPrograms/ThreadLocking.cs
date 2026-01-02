using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadingPrograms
{
    public class ThreadLocking
    {
        public void Display()
        {
            lock (this)
            {
                Console.Write("[C Shrap is an");
                Thread.Sleep(2000);
                Console.WriteLine(" object oriented programming language");
            }
        }

        static void Main()
        {
            /*
            ThreadLocking threadLocking = new ThreadLocking();
            threadLocking.Display();
            threadLocking.Display();
            threadLocking.Display();
            */

            ThreadLocking obj = new ThreadLocking();
            Thread t1 = new Thread(obj.Display);
            Thread t2 = new Thread(obj.Display);
            Thread t3 = new Thread(obj.Display);
            t1.Start();
            t2.Start();
            t3.Start();

            var ta = new Thread(obj.Thread1);
            var tb = new Thread(obj.Thread2);

            ta.Start();
            tb.Start();
        }

        // DeadLock
        object lockA = new object();
        object lockB = new object();

        void Thread1()
        {
            lock (lockA)
            {
                Console.WriteLine("Thread1 acquired lockA");
                Thread.Sleep(100);

                lock (lockB)
                {
                    Console.WriteLine("Thread1 acquired lockB");
                }
            }
        }
        void Thread2()
        {
            lock (lockB)
            {
                Console.WriteLine("Thread2 acquired lockB");
                Thread.Sleep(100);

                lock (lockA)
                {
                    Console.WriteLine("Thread2 acquired lockA");
                }
            }
        }

    }
}
