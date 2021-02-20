using GameProject.Business.Abstract;
using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + "\n" + "Tebrikler; Kaydınız Başarıyla Gerçekleşmiştir!");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız, Kayıt başarısız!");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + "\n" + "Kaydınız Başarıyla Silinmiştir!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + "\n" + "Kaydınız Başarıyla Güncellenmiştir!");
        }
    }
}
