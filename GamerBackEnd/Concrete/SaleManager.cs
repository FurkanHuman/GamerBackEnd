using GamerBackEnd.Abstract;
using GamerBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerBackEnd.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Sale(Customer customer, Product product)
        {
            Console.WriteLine(customer.Name + " " + product.Name + " ürünü" + product.Price + " ₺ aldı.");
        }
    }
}
