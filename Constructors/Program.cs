using System;

namespace Constructors

//Constructor bir class ı newlediğimiz zaman çalışan bloktur.
//Bir class ilk kez oluştuğu zaman bir kere çalışır ve bir daha çalışmaz.

{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id=1, FirstName="Talha", LastName="Gamga", City="Osmaniye"};
            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Betül";
            customer3.LastName = "Gamga";
            customer3.City = "Osmaniye";
            //buradaki customer1 ve customer3 aynı mantıkla çalışır. parametresiz olan constructor'a girer.

            Customer customer2 = new Customer(2, "Ömer", "Alkaş", "Osmaniye"); //method mantığı ile çalışır '()'
            Console.WriteLine(customer2.FirstName);

        }
    }
    
    class Customer
    {
        //Arka planda default bir constructor vardır eğer biz tanımlarsak bizim constructorumuz çalışır.
        public Customer()
        {

        }
        
        public Customer(int id, string firstname, string lastname, string city)
        {
            Console.WriteLine("Yapıcı blok çalıştı");
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            City = city;

            
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}   

