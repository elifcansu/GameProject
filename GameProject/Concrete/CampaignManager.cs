using GameProject.Abstract;
using GameProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaingService
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaingName + " Kampanyası Eklendi");
        }

        public void Delete(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaingName + " Kampanyası Silindi");
        }

        public void Update(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaingName + " Kampanyası Güncellendi");
        }
    }
}
