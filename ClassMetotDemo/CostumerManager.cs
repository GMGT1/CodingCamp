using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CostumerManager
    {
        public void AddCostumer(Costumer costumer)
        {
            Console.WriteLine(costumer.Name + " adlı müşteri eklendi.");
        }


        public void ShowCostumer(Costumer costumer)
        {
            Console.WriteLine("Id: " + costumer.Id);
            Console.WriteLine("Name: " + costumer.Name);
            Console.WriteLine("Surname: " + costumer.Surname);
            Console.WriteLine("Call number: " + costumer.CallNumber);

        }
    }
}
