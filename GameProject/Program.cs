using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1999,
                FirstName = "GÖKALP",
                LastName = "AVCU",
                IdentityNumber = 12345678912
            });
            Console.WriteLine("Hello World!");
        }
    }
}
