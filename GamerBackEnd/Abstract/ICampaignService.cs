using GamerBackEnd.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerBackEnd.Abstract
{
    public interface ICampaignService
    {
        void Add(Product product, int rate);
    }
}
