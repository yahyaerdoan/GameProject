using GameProject.Business.Abstract;
using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.DateOfBirth == 1993 && gamer.FirstName == "Yahya"
                && gamer.LastName == "ERDOĞAN" && gamer.IdentityNumber == 1)
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
