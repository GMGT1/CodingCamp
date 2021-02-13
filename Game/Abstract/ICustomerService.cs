using GameWork.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWork.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
        void Delete(Customer customer);
        void Update(Customer customer);

    }
}
