using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {                       
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //IPerson person = new IPerson(); //İnterfacelerin instansı oluşturulamaz yani newlenemez.

            //IPerson person1 = new Customer();     (T)
            //IPerson person2 = new Student();      (T)

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {   
                new SqlServerCustomerDal(), 
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", Adress = "Ankara" });                             

            Student student = new Student() { Id = 2, FirstName = "Derin", LastName = "Demiroğ", Department = "Computer Sciences" };
            manager.Add(student);                               //Extract method CTRL + R + M

            manager.Add(new Customer { Id = 3, FirstName = "Talha", LastName = "Gamga", Adress = "Osmaniye" });

            manager.Add(new Worker { Id = 4, FirstName = "Baran", LastName = "Gamga", Department = "3d art" });
        }
    }
    interface IPerson //Bir interfacenin instans'ı oluşturulamaz yani newlenemez.
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }

    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}

