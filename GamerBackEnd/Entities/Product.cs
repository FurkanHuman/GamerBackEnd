using System;
using System.Collections.Generic;
using System.Text;

namespace GamerBackEnd.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private double price;
        public double Price
        {
            get
            {
                return price - Rate;
            }
            set
            {
                price = value;
            }
        }
        public int Rate { get; set; }
    }
}
