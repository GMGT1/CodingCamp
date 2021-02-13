using GameWork.Abstract;
using GameWork.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWork.Concrete
{
    public class EpicgamesCustomerManager:BaseCustomerManager
    {
        public override void PersonalDiscount(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " adlı kişiye epicgames'den %7 indirim daha !");
        }

        public override void Save(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " EpicGames Veritabanına kaydedildi.");
        }
    }
}
