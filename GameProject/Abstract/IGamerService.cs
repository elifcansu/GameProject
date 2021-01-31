using GameProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IGamerService
    {
        public void Add(User user);
        public void Update(User user);
        public void Delete(User user);

    }
}
