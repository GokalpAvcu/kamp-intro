using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class userValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1999 && gamer.FirstName =="GÖKALP" && 
                gamer.LastName =="AVCU" && gamer.IdentityNumber==12345678912)
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
