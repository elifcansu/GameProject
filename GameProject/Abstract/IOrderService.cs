using GameProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IOrderService
    {
        public void Sell(List<Game> games, Gamer gamer, Campaing campaing);
    }
}
