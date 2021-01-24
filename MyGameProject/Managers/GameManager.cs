using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    class GameManager : IGameService, IGameUserService
    {
        List<Game> gamesData = new List<Game>();
        private List<Game> gamesOfUser = new List<Game>();
     

        public void Examine(Game game)
        {
            Console.WriteLine(game.GameInfo);
        }
        public void Buy(Game game,Player player)
        {
            player.PlayerWallet = player.PlayerWallet - game.GamePrice;
            gamesOfUser.Add(game);
            Console.WriteLine($"you bought the game that {game.GameName}!");
            Console.WriteLine($"Updated wallet = {player.PlayerWallet}$");
        }

        public void Return(Game game, Player player)
        {
            //if (player.Games.SelledTime)
            //{
            // burada yapmam gereken işlemi bilmiyorum. Amacım 15 günü geçtiyse iade edemesin!!
            player.PlayerWallet = game.GamePrice + player.PlayerWallet;
            gamesOfUser.Remove(game);
            //}
            Console.WriteLine($"you returned the game that {game}!");
        }

        public void Sell(Game game, Player player)
        {
            // %30 koydum abi düşünmeden satmayıver :)
            player.PlayerWallet = player.PlayerWallet- (game.GamePrice * 0.30);
            gamesOfUser.Remove(game);
            Console.WriteLine($"you selled the game that {game}!");
        }

        public void Add(Game game)
        {
            gamesData.Add(game);
            Console.WriteLine("Added!");
        }

        public void Delete(Game game)
        {
            gamesData.Remove(game);
            Console.WriteLine("Deleted!");
        }

        public void Update(Game game,Game game1)
        {
            gamesData.Remove(game);
            gamesData.Add(game1);
            Console.WriteLine("Updated!");
        }
    }
}
