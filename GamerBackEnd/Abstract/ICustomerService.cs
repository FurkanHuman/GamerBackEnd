using GamerBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerBackEnd.Abstract
{
    interface ICustomerService
    {
        void Add(Customer customer);
    }
}
