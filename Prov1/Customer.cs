using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov1
{
    class Customer
    {
        public int money;
        public string name;
        private List<string> names = new List<string>() {"A", "B" };
        private int randomToString;
        private Random generator = new Random();

        public void Customers()
        {
            money = generator.Next(0, 30);
            randomToString = generator.Next(names.Count);
            name = names[randomToString];
        }
        public void PrintInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Money: " + money);
        }
    
    }
}
