using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    interface IUserCampaignService
    {
        void CalculatePrice(Campaign campaign,Game game);
        void Use(Campaign campaign, Game game);

    }
}
