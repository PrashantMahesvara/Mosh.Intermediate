using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {            
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }

        //below code would be required if not using dictionary

        //public void SetItem(string key, string value)
        //{

        //}

        //public string GetItem(string key)
        //{

        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Pingvin";
            Console.WriteLine(cookie["name"]);
            Console.ReadKey();
        }
    }
}
