using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Product
    {
        private decimal _price;
        private int _count;

        
        public decimal Price
        {
            get { return _price; }
            set
            {

                if (value > 0)
                {
                    _price = value;
                }
            }
        }

        public int Count
        {
            get { return _count; }
            set
            {
                if (value > 0)
                {
                    _count = value;
                }
            }
        }

        
        public int No { get; set; }
        public string Name { get; set; }
    }


}

