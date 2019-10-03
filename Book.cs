using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov1
{
    class Book
    {
        public int price;
        private string name;
        private int rarity;
        private string category;
        private int actualValue;
        private bool cursed;
        private Random generator = new Random();

        public void Books()
        {
            actualValue = generator.Next();
            rarity = generator.Next();
            int intToBool = generator.Next(0,10);
            if (intToBool < 5)
            {
                cursed = false;
            }
            else if (intToBool > 5)
            {
                cursed = true;
            }

           
            List<string> names = new List<string>() {"HP", "SN", "LMD", "LOTR" };
            List<string> categories = new List<string>() {"Fantasy", "Novel", "History" };

            int namesIndex = generator.Next(names.Count);
            int categoriesIndex = generator.Next(categories.Count);

            name = names[namesIndex];
            category = categories[categoriesIndex];
                                                

        }
        public void PrintInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Category: " + category);
            Console.WriteLine("Rarity: " + rarity);
            Console.WriteLine("Price: " + price);
        }
        public int Evaluate()
        {
           int calcPriceM = actualValue * rarity;
           int possiblePrice = (actualValue * rarity) / 2;
           int possiblePrice2 = (calcPriceM + possiblePrice);
           price = generator.Next(possiblePrice, possiblePrice2);
           return price;

        }
        public string GetCategory()
        {
            return category;
        }
        public string GetName()
        {
            return name;
        }
        public bool IsCursed()
        {
            int i = generator.Next(1, 10);
            if (i < 8 || i == 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
