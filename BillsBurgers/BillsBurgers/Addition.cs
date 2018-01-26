using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillsBurgers
{
    public class Addition
    {
        private static int _instances = 0;

        //public List<> List { get; set; }
        public double Price { get; set; }

        public Addition()
        {
            _instances++;
        }



        public static int additionsCount()
        {
            return _instances;
        }
    }
}
