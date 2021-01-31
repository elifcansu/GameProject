using GameProject.Abstract;
using GameProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(User user)
        {
            if (_userValidationService.Validate(user) == true)
            {
                Console.WriteLine("kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt olunamadı.");
            }
            
        }

        public void Delete(User user)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(User user)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
