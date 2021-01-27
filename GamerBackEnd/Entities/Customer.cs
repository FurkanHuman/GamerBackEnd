using System;
using System.Collections.Generic;
using System.Text;

namespace GamerBackEnd.Entities
{
    public class Customer
    {
        public int GamerId { get; set; }
        public string Name { get; set; }
        public string SName { get; set; }
        public Int64 NatId { get; set; }
        public DateTime YearOfBirth { get; set; }
    }
}
