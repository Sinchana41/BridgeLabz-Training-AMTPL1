using System;

namespace EventsProgram
{
    //1.Declare Delgate
    public delegate void MyEventHandler(string message);

    class Process
    {
        //2.Declare Event
        public event MyEventHandler ProcessStarted;

        public void Start()
        {
            Console.WriteLine("Starting");
            //3.Raise Event
            ProcessStarted?.Invoke("Process Started Event Fired");
        }
    }

    class Program
    {
        static void Main()
        {
            Process p = new Process();

            // Subscribe to the event
            p.ProcessStarted += MessageHandler;

            p.Start();
        }

        static void MessageHandler(string msg)
        {
            Console.WriteLine("Event Message: " + msg);
        }
    }
}