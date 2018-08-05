using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Classes.Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Hwi! Press Enter to start the clock!");

            Console.ReadKey();

            var stopWatch = new Stopwatch();

            var startTime = Stopwatch.Start(DateTime.Now);

            Console.WriteLine("Time started at: " + startTime);

            Console.ReadKey();

            var stopTime = Stopwatch.Stop(DateTime.Now);


            Console.WriteLine("Time stopped at: " + stopTime);


            Console.ReadKey();

            


            Console.WriteLine();

        }
    }
}
