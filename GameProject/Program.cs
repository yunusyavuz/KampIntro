using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
          //  GamerManager gamerManager= new GamerManager(new UserValidationManager());
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer() 
            { Id=1, BirthYear= 1987, FirstName="Yunus",
             LastName= "Yavuz", IdentityNumber = 12345});

        }
    }
}
