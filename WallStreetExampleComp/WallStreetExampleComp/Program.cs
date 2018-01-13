using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallStreetExampleComp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What stock do you want to buy?");
            var nameInput = Console.ReadLine();
            Console.WriteLine("How much of {0} do you want to buy?", nameInput);
            var amountInput = Console.ReadLine();
            var numAmount = Convert.ToDecimal(amountInput);
            var stock = new Stock(nameInput);
            BuyItem.Buy(numAmount, stock);
            Console.WriteLine("You have just bought {0} shares of {1}.", stock.Quantity, stock.Name);

        }

        public class Stock
        {

            public string Name { get; set; }

            public decimal Quantity { get; set; }

            public decimal TotalValue { get; set; }

            public Stock(string name)
            {
                this.Name = name;
                this.Quantity = 0;
            }

        }


        public static class BuyItem
        {
            public static void Buy(decimal quantity, Stock stock)
            {
                stock.Quantity += quantity;
            }
        }
        
    }
}
