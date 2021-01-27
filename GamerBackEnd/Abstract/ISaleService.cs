using GamerBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerBackEnd.Abstract
{
    public interface ISaleService
    {
        void Sale(Customer customer, Product product);
    }
}
