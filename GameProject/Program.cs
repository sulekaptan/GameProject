using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                IdentityNumber = "123456",
                FirstName = "Şule",
                LastName = "Kaptan",
                BirthYear = 2000
            });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Order();
        }
    }
}
