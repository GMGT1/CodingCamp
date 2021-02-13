using GameWork.Abstract;
using GameWork.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWork.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        bool ICustomerCheckService.CheckPerson(Customer customer)
        {
            return true;
        }
    }
}
