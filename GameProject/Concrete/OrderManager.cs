using GameProject.Abstract;
using GameProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class OrderManager : IOrderService
    {
        public void Sell(List<Game> games, Gamer gamer, Campaing campaing)
        {
            foreach (var game in games)
            {
                game.GamePrice = game.GamePrice - game.GamePrice * campaing.Discount;
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + game.GameName + " oyununu " + campaing.CampaingName + " Kampanyası ile " + game.GamePrice + " TL'ye satın almıştır.");

            }
        }
    }
}
