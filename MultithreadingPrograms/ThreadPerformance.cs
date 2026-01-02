using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadingPrograms
{
    public class ThreadPerformance
    {
        static void HeavyTask()
        {
            long sum = 0;
            for (int i = 1; i <= 1_000_000_00; i++)
            {
                sum += i;
            }
        }

        public static void SingleThreadExecution()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            HeavyTask();
            HeavyTask();

            sw.Stop();
            Console.WriteLine("Single Thread Time: " + sw.ElapsedMilliseconds + " ms");
        }

        public static void MultiThreadExecution()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            Thread t1 = new Thread(HeavyTask);
            Thread t2 = new Thread(HeavyTask);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            sw.Stop();
            Console.WriteLine("Multi Thread Time: " + sw.ElapsedMilliseconds + " ms");
        }

        public static void Main()
        {
            Console.WriteLine("Thread Performance Comparison\n");

            SingleThreadExecution();//Single Thread Time: 469 ms
            MultiThreadExecution();//Multi Thread Time: 308 ms

            Console.ReadLine();
        }
    }
}
