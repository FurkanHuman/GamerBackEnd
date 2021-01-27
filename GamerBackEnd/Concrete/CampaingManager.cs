using GamerBackEnd.Abstract;
using GamerBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerBackEnd.Concrete
{
    public class CampaingManager : ICampaignService
    {
        public void Add(Product product, int rate)
        {
            product.Rate = rate;
        }
    }
}
