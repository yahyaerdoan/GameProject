using GameProject.Business.Abstract;
using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Adapters;

namespace GameProject.Business.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        IUserValidationService userValidationService;
        public bool Validate(Gamer gamer)
        {
            userValidationService = new MernisServiceAdapter();
            
            return userValidationService.Validate(gamer);
        }
    }
}
