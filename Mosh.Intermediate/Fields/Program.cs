using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        //public List<Order> Orders;
        public readonly List<Order> Orders = new List<Order>();

        //public Customer()
        //{
        //    Orders = new List<Order>();
        //}

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Id = id;
            this.Name = name;
        }

        public void Promote()
        {
            //Orders = new List<Order>(); causes error
        }

    }

    public class Order
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(0, "Broseph");
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            Console.WriteLine(customer.Orders.Count());
            Console.ReadKey();

        }
    }
}
