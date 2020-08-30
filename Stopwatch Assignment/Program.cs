using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace StopwatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            Console.WriteLine("Press Any key to start stopwatch.");
            Console.ReadKey();
            stopwatch.Start();
            Console.Clear();
            Console.Title = "STOPWATCH";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nStopwatch Started. Press Any key to stop");
            Console.ReadKey();
            Console.Clear();
            stopwatch.End();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Time Duration: " + stopwatch.Interval + "\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();


        }
    }

    public class Stopwatch
    {

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public bool IsStarted { get; set; }
        public TimeSpan Interval { get { return EndTime - StartTime; } }


        public void Start()
        {
            if (!IsStarted)
            {
                StartTime = DateTime.Now;
                IsStarted = true;
            }

        }

        public void End()
        {
            if (IsStarted)
            {
                EndTime = DateTime.Now;
                IsStarted = false;
            }


        }

    }
}
