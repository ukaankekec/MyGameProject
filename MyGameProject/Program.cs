using System;
using System.Collections.Generic;

namespace MyGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player() { PlayerId = 1, PlayerUserName = "ukaankekec", PlayerPassword = "123", PlayerWallet = 1352.5 };
            Player player2 = new Player() { PlayerId = 2, PlayerUserName = "kaankekecc", PlayerPassword = "123", PlayerWallet = 1200.5 };

            Game game1 = new Game() { GameId = 1, GameName = "game1", GamePrice = 44.89, GameInfo = "cok iyi oyun" };
            Game game2 = new Game() { GameId = 2, GameName = "game2", GamePrice = 464.89, GameInfo = "cok iyi oyun2" };

            Campaign campaign1 = new Campaign() { CampaignId = 1, CampaignName = "cok iyi kampanya", CampaignDiscount = 0.12, CampaignInfoCondition = "şartsız" };
            Campaign campaign2 = new Campaign() { CampaignId = 2, CampaignName = "cok iyi kampanya2", CampaignDiscount = 0.72, CampaignInfoCondition = "kefilsiz" };

            PlayerManager playerManager = new PlayerManager();
            GameManager gameManager = new GameManager();
            CampaignManager campaignManager = new CampaignManager();

            Console.WriteLine(game1.GamePrice);
            campaignManager.Use(campaign1, game1);
            

            Console.WriteLine(player1.PlayerWallet);
            playerManager.Deposit(player1, 312);
            

            
            gameManager.Buy(game2, player2);
            




        }
    }
}
