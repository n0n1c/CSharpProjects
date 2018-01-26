using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillsBurgers
{
    public class Hamburger
    {
        public string RollType { get; set; }
        public string Meat { get; set; }
        public List<Addition> Additions { get; set; }
        public double Price { get; set; }

        public Hamburger(string roll, string meat)
        {
            this.RollType =
                this.Meat = Meat;
            this.Price = 5.00;
        }
    }
}
