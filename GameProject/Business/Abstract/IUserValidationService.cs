using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Abstract
{
    public interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
