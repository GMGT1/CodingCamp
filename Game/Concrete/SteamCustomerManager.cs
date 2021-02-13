using GameWork.Abstract;
using GameWork.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWork.Concrete
{
    public class SteamCustomerManager : BaseCustomerManager
    {

        private ICustomerCheckService _customerCheckService;

        public SteamCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;

        }
        public override void PersonalDiscount(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " adlı kişiye Steam'den %13 indirim daha !");
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckPerson(customer))
            {
                Console.WriteLine(customer.FirstName + " Steam'a eklendi");
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}
