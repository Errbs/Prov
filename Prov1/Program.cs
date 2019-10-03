using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Want to look at a new book? write yes or no");
            string answer = Console.ReadLine();
            if(answer == "yes")
            {
                Book b1 = new Book();
                b1.Books();
                b1.Evaluate();
                b1.PrintInfo();
            }

            Console.WriteLine("Randomize customer? write yes or no");
            answer = Console.ReadLine();
            if(answer == "yes")
            {
                Customer c1 = new Customer();
                c1.Customers();
                c1.PrintInfo();
            }

            Console.ReadLine();

        }
    }
}
