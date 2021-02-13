using System;

namespace ClassesWorking
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();


            Customer customer = new Customer();
            customer.Id = 1;
            customer.City = "Ankara";
            customer.FirstName = "Talha";
            customer.LastName = "Gamga";

            Customer customer2 = new Customer 
            {
                Id=2, City="İstanbul", FirstName="Betül", LastName="Gamga"
            };

            Console.WriteLine(customer2.FirstName);

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Talha";
            customer3.LastName = "Gamga";
            customer3.City = "Osmaniye";
            customer3.Unvan = "Junior";

            Console.WriteLine(customer3.Unvan);


        }
    }
}
