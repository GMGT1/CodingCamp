using GameWork.Abstract;
using GameWork.Concrete;
using GameWork.Entities;
using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { FirstName = "Talha", LastName = "Gamga", Age = 18, Country = "Türkiye", Gender = "Erkek" };
            Customer customer2 = new Customer() { FirstName = "Baran", LastName = "Gamga", Age = 24, Country = "Türkiye", Gender = "Erkek" };
            Console.WriteLine("---------------------STEAM---------------------");
            Console.WriteLine("\n");

            BaseCustomerManager steamCustomerManager = new SteamCustomerManager(new CustomerCheckManager());
            steamCustomerManager.Save(customer1);
            steamCustomerManager.AddCampaign();
            steamCustomerManager.PersonalDiscount(customer1);

            Console.WriteLine("\n");

            Console.WriteLine("-------------------EPİC GAMES-------------------");
            Console.WriteLine("\n");

            BaseCustomerManager epicgamesCustomerManager = new EpicgamesCustomerManager();
            epicgamesCustomerManager.Save(customer2);
            epicgamesCustomerManager.Update(customer2);
            epicgamesCustomerManager.AddCampaign();
            epicgamesCustomerManager.UpdateCampaign();
            epicgamesCustomerManager.PersonalDiscount(customer2);
        }
    }
}
