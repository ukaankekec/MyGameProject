using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    interface IGameUserService
    {
        void Buy(Game game, Player player);
        void Sell(Game game, Player player);
        void Return(Game game, Player player);
        void Examine(Game game);
    }
}
