using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    interface IPlayerService
    {
        void CreateNewAccount(Player player);
        void DeleteAccount(Player player);

        void Deposit(Player player, double amount);
        
        

    }
}
