using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new Gamer(new UserValidationManager());
            gamerManager.Add(new Gamer {
                Id =1,
                BirthYear=1985,
                FirstName="İsmail",
                LastName="Coşar",
                IdentityNumber=12345
            });
        }
    }
}
