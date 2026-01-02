using System;

public class ThreadDemo
{
    static void Test1()
    {
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("Test1: "+ i);
        }
        Console.WriteLine("Thread is Exiting");
    }
    static void Test2()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                Console.WriteLine("Thread going to sleep");
                Thread.Sleep(5000);
                Console.WriteLine("Thread Woke up");
            }
            Console.WriteLine("Test2: "+ i);
        }
        Console.WriteLine("Thread is Exiting");
    }
    static void Test3()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Test3: "+ i);
        }
        Console.WriteLine("Thread is Exiting");
    }
   /* static void Main()
    {
        Thread  t = Thread.CurrentThread;
        t.Name =  "Main Thread";
        Console.WriteLine("Current executing thread: "+t.Name);
        // Single Threaded Model - methods are going to execute one after the other
        Test1();
        Test2();
        Test3();

        //Multithreading
        Thread t1 = new Thread(Test1);
        Thread t2 = new Thread(Test2);
        Thread t3 = new Thread(Test3);

        t1.Start();
        t2.Start();
        t3.Start();

        Console.WriteLine("Main Thread is Exiting");
        t1.Join();
        t2.Join(3000);//Join() is Overloaded method
        t3.Join();
    }*/
}