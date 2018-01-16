using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WallStreetExampleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public class Item
        {
            public string Name { get; set; }

            public decimal Quantity { get; set; }

            public decimal TotalValue { get; set; }

            public void Buy(decimal quantity)
            {
                this.Quantity += quantity;
            }

        }

        public class Stock : Item
        {
             
        }

    }
}
