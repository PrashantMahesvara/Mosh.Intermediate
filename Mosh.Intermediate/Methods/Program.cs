using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");

            Move(newLocation.X, newLocation.Y);
        }
    }

    public class Calculator
        {
            public int Add(params int[] numbers)
            {
                var sum = 0;
                    foreach (var number in numbers)
                    {
                        sum += number;
                    }
                return sum;
            }
        }

    class Program
    {
        static void Main(string[] args)
        {

        }

        static void Parse()
        {
            //var number = int.Parse("abc");

            //example 1, Parse
            try
            {
                var num = int.Parse("abc");
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion failed");
            }

            //example 2, TryParse
            int number;
            var result = int.TryParse("abc", out number); //if using Parse, you need a try/catch block. TryParse 
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed");
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(2, 4)); //params key word
            //Console.WriteLine(calculator.Add(new int[] { 14, 4, 53, 774})); this one is not required, better to not have new 
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error has occured...");
                Console.ReadKey();
            }
        }
    }
}
