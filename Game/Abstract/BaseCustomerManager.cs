using GameWork.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWork.Abstract
{
    public abstract class BaseCustomerManager : BaseCampaignManager, ICustomerService
    {
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " adlı müşteri veritabanından silindi.");
        }

        public virtual void Save(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " adlı müşteri veritabanına kaydedildi.");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " adlı müşteri bilgileri güncellendi.");
        }
    }
}
