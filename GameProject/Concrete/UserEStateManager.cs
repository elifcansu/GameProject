using GameProject.Abstract;
using GameProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class UserEStateManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            if (user.Id == 1 && user.FirstName == "ELİF" && user.LastName == "ERTÜRK" && user.BirthYear == 1993 && user.IdentityNumber == 1234567899)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
