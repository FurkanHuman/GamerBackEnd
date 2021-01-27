using GamerBackEnd.Abstract;
using GamerBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerBackEnd.Concrete
{
    class ProductManager : IProductService
    {
        public void Add(Product product)
        {
            Data.Datas.Products.Add(product);
        }
    }
}
