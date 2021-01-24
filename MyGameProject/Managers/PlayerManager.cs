using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    class PlayerManager : IPlayerService
    {
        private List<Player> players = new List<Player>();

        public void CreateNewAccount(Player player)
        {
            players.Add(player);
        }

        public void DeleteAccount(Player player)
        {
            players.Remove(player);
        }

        public void Deposit(Player player,double amount)
        {
            player.PlayerWallet = player.PlayerWallet + amount;

            Console.WriteLine($"Updated wallet : {player.PlayerWallet}$");
        }
    }
}
