using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 1 && gamer.IdentityNumber == "123456" && gamer.FirstName == "Şule" &&
                gamer.LastName == "Kaptan" && gamer.BirthYear == 2000)
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
