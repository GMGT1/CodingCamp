using GameWork.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWork.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckPerson(Customer customer);
    }
}
