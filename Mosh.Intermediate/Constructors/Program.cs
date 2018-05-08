using System;
using System.Collections.Generic;

namespace Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            :this() // this keyword here initializes the method with no parameters
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            :this(id) // this keyword here initializes the method with the id parameter
        {
            this.Id = id;
            this.Name = name;
        }
    }

    public class Order
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "Brohan";

            //var order = new Order(); this is not a good solution. The main method is not responsible for initializing the list

            Console.WriteLine("Name of the person is {0} and the id is {1}", customer.Name, customer.Id);
            Console.ReadKey();
        }
    }
}
