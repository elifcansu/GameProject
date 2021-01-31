using GameProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ICampaingService
    {
        public void Add(Campaing campaing);
        public void Update(Campaing campaing);
        public void Delete(Campaing campaing);
    }
}
