using System;
namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int, decimal, float, enum, boolean (sayısal veriler, değişkenler => değer tiptir)
            int sayi1 = 4;
            int sayi2 = 20;

            sayi1 = sayi2;

            sayi2 = 100;

            Console.WriteLine(sayi1);
            //cevap 20 olur.

            ////////////////////////////////////////
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine(sayilar1[0]);
            //cevap 1000 olur.



            //Array, class, interface => referans tiptir.
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";
            person2 = person1;
            //adres eşitlemesi
            person1.FirstName = "Derin";
            Console.WriteLine(person2.FirstName);
            
            person2.FirstName = "Talha";
            Console.WriteLine(person1.FirstName);


            Customer customer = new Customer();
            Employee employee = new Employee();
            //customer = employee; diyemeyiz! çünkü bunlar farklı tipler.
            customer.FirstName = "Betül";
            employee.FirstName = "seNpaiTR";


            Person person3 = customer; //Referans adreslerini eşitledik.
            Console.WriteLine(person3.FirstName);
            customer.CreditCard = "1234567897";
            (((Customer)person3).CreditCard) = "123,456,8";

            //Customer boxingi yaparak person3'ün CreditCard numarasına erişebiliriz.
            Console.WriteLine(((Customer)person3).CreditCard);

            
            PersonManager personManager = new PersonManager(); 
            personManager.Add(customer);
            personManager.Add(employee);



            




        } 

    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    //Base class : Person
    class Customer:Person  //Customer sınıfının nesneleri bir Person dır.
    {
        public string CreditCard { get; set; }
    }

    //Base class : Person
    class Employee:Person  //Employee sınıfının nesneleri de bir Person dır.
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person) //Person objesi istersek burada hem Person, hem Customer hem de Employee objelerini kullanabiliriz.
        {
            Console.WriteLine(person.FirstName + " eklendi...");
        }
    }
}
    