using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager : CampaignManager
    {
        public void Order(Campaign campaign)
        {
            Console.WriteLine("Sold!");
        }
    }
}
