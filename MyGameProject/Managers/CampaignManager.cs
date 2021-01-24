using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    class CampaignManager :ICampaignService,IUserCampaignService
    {


        List<Campaign> campaigns = new List<Campaign>();
        public void ExamineCampaigns()
        {
            foreach (Campaign campaign in campaigns)
            {
                Console.WriteLine($"Campaign name:{campaign.CampaignName}--Discount:%{campaign.CampaignDiscount}");
                Console.WriteLine(campaign.CampaignInfoCondition);
            }
        }

       

        public void Add(Campaign campaign)
        {
            campaigns.Add(campaign);
            Console.WriteLine("Added!");
        }

        public void CalculatePrice(Campaign campaign,Game game)
        {
            Console.WriteLine($"The price that calculated for you is { campaign.CampaignDiscount* game.GamePrice}$");
        }

        public void Use(Campaign campaign, Game game)
        {
            game.GamePrice = campaign.CampaignDiscount * game.GamePrice;

            Console.WriteLine("Used!");

        }

        public void Delete(Campaign campaign)
        {
            bool done = true;
            while (done)
            {


                Campaign[] temporary = new Campaign[1];
                temporary[0] = campaign;
                bool delete = true;

                while (delete)
                {
                    Console.WriteLine("Are you sure to update?(yes/no)");
                    string up = Console.ReadLine();
                    if (up == "Yes" || up == "yes")
                    {
                        delete = false;
                        done = false;
                        campaigns.Remove(campaign);
                        
                        Console.WriteLine("Deleted!");

                    }
                    else
                    {

                        delete = true;
                        done = false;
                    }

                }

            }
        }

        public void Update(Campaign campaign, Campaign campaignNew)
        {
            bool done = true;
            while (done)
            {


                Campaign[] temporary = new Campaign[1];
                temporary[0] = campaign;
                bool update = true;

                while (update)
                {
                    Console.WriteLine("Are you sure to update?(yes/no)");
                    string up = Console.ReadLine();
                    if (up == "Yes" || up == "yes")
                    {
                        update = false;
                        done = false;
                        campaigns.Remove(campaign);
                        campaigns.Add(campaignNew);
                        Console.WriteLine("Updated!");
                        
                    }
                    else
                    {
                        
                        update = true;
                        done = false;
                    }

                }

            }
            
        }
        
    }
}
