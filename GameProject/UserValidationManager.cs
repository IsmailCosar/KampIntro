﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1985 && gamer.FirstName == "İsmail" && gamer.LastName =="Coşar" && gamer.IdentityNumber==123456)
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
