using System;
using System.Linq;

namespace TRYİNG
{
    class Program
    {
        static void Main(string[] args)
        {
            float sayi = 1.5F;
            Console.WriteLine(sayi);

            double sayi2 = 123546D;
            Console.WriteLine(sayi2);

            int sayi3 = (int)sayi;
            Console.WriteLine(sayi3);

            Console.WriteLine("Enter username:");

            string userName = Console.ReadLine(); // this is equal to input in python.

            Console.WriteLine("username: " + userName);

            //Console.WriteLine(Console.ReadLine()); //Console.Readline is used to get input from users.

            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());//Normally it get a string type data but we converted to int with a method.
            Console.WriteLine("your age: " + age);

            Console.WriteLine(Math.Max(19, 92)); // it returns the highest value from parameters.

            Console.WriteLine(Math.Min(19, 92)); // it returns the highest value from parameters.

            string text1 = "qweoıuaskdjh";
            Console.WriteLine(text1.Length); //the length of any string can be found with Length method.

            string text2 = "HellO WoRlD";
            Console.WriteLine(text2.ToUpper());// All of letters be capital
            Console.WriteLine(text2.ToLower());// All of letters will be small


            string fistName = "Talha";
            string lastName = "Gamga";
            string name = $"My full name is : {fistName} {lastName}";
            Console.WriteLine(name);


            string myString = "Hello";
            Console.WriteLine(myString.IndexOf("o"));


            string myMidName = "Ubeydullah";
            Console.WriteLine(myMidName.Substring(1, 4));


            string txt = "We are the so-called \"Vikings\" from the north."; // '\' character is escape character.

            bool isCsharpFun = true;
            bool isFistTasty = false;
            Console.WriteLine(isCsharpFun);
            Console.WriteLine(isFistTasty);


            int time = 20; //my variable

            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            //can be simply written 'variable = (condition) ? expressionTrue :  expressionFalse;'

            string result = (time < 18) ? "good day." : "good evening";
            Console.WriteLine(result);


            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;


                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;

                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }

            string[] cars = { "Volvo", "Bmw", "Ford", "Mazda" };


            int[] myNumbers = new int[] { 5, 1, 8, 9 };


            string[] FistName = new string[2];
            FistName[0] = "Talha";
            FistName[1] = "Halil";

            string[] LastName = new string[3] { "Gamga", "Yıldırım", "Dardan" };

            string[] NickName = new string[] { "hax", "senpaitr", "voodo" };

            Car Ford = new Car();
            Console.WriteLine(Ford.model);

            Phones Asus = new Phones("Zenfone2");
            Console.WriteLine(Asus.model);

            Mice mice = new Mice();
            mice.AnimalSound();
            mice.Sleep();


        }
    }    
    class Car
    {
        public string model;

        public Car()//constructor
        {
            model = "Mustang";
        }
    }

    class Phones
    {
        public string model;
        public Phones(string modelName)
        {
            model = modelName;
        }
    }

    class Person
    {
        private string name; // field

        public string Name // property
        {
            get { return name; } // get method
            set { name = value; } // set method
        }
    }

    abstract class Animal //Abstract classes can not be used to create an object.
    {
        public abstract void AnimalSound();
        public void Sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    class Mice:Animal //We inherited from Animal abstract class.
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Mice is caught");
        }
    }
}
