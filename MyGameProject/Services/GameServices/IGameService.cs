using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game,Game game1);
    }
}
