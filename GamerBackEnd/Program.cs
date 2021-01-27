using GamerBackEnd.Abstract;
using GamerBackEnd.Concrete;
using GamerBackEnd.Entities;
using System;

namespace GamerBackEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                GamerId = 1,
                Name = "Ali",
                SName = "Kim",
                NatId = 12345678910,
                YearOfBirth = new DateTime(1998, 1, 1)
            };

            Product product = new Product
            {
                Id = 1,
                Name = "Kulaklık",
                Price = 150,
                Rate = 0
            };

            ICustomerService customerService = new CustomerManager();
            customerService.Add(customer);

            IProductService productService = new ProductManager();
            productService.Add(product);

            ICampaignService campaignService = new CampaingManager();
            campaignService.Add(product, 10);

            ISaleService saleService = new SaleManager();
            saleService.Sale(customer, product);
        }
    }
}
