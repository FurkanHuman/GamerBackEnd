using GamerBackEnd.Abstract;
using GamerBackEnd.Adapter;
using GamerBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerBackEnd.Concrete
{
    class CustomerManager : ICustomerService
    {
        public void Add(Customer customer)
        {
            if (MersisAdapter.Dogrula(customer)) // ekleme de kontrol tc kimlik tm
                Data.Datas.Customers.Add(customer);
            else
                Console.WriteLine("Hatalı Kullanıcı Bilgisi");
        }
    }
}
