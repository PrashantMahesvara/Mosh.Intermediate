using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Person
    {
        public DateTime Birthdate { get; private set; }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person(); will not work, since the birthdate is set in the constructor of the class
            var person = new Person(new DateTime(1982, 1, 1));
            Console.WriteLine(person.Age);
        }
    }
}
