using GameProject.Concrete;
using GameProject.Entity.Concrete;
using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
           
            

            User user = new User
            {
                Id = 1,
                FirstName = "ELİF",
                LastName = "ERTÜRK",
                BirthYear = 1993,
                IdentityNumber = 1234567899
                
            };

            
            GamerManager gamerManager = new GamerManager(new UserEStateManager()); //burada bizim fake validation yerine artık edevlet sistemini de kullanabiliriz.
            gamerManager.Add(user);

            Gamer gamer = new Gamer
            {
                Id = 1,
                FirstName = "ELİF",
                LastName = "ERTURK",
                BirthYear = 1993,
                IdentityNumber = 1234567899,
                NickName="ElifCansu"

            };

            Game game1 = new Game { GameId = 1, GameName = "Portal", GamePrice = 25 };
            Game game2 = new Game { GameId = 2, GameName = "Forest", GamePrice = 87.25 };
            List<Game> games = new List<Game> { game1, game2 };

            Campaing campaing = new Campaing { CampaingId = 1, CampaingName = "Yeni Yıl İndirimi", CampaingType = "İndirim", Discount = 0.5 };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaing);

            OrderManager orderManager = new OrderManager();
            orderManager.Sell(games, gamer, campaing);

            

        }
    }
}
