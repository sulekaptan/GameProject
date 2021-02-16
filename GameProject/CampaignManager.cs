using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine("Campaign deleted.");
        }

        public void NewCampaign(Campaign campaign)
        {
            Console.WriteLine("Campaign added.");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine("Campaign updated");
        }

        internal void Order()
        {
            Console.WriteLine("Sold!");
        }
    }
}
