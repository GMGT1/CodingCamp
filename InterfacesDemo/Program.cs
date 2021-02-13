using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Iworker[] workers = new Iworker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            
            foreach (var worker in workers)
            {
                worker.Work();
            }

            
            
            IEat[] eats = new IEat[2] 
            {
                new Worker(),
                new Manager()
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }



            ISalary[] salaries = new ISalary[2]
            {
             new Manager(),
             new Worker()
            };

            foreach (var salary in salaries)
            {
                salary.GetSalary();
                salary.GetSalary();
            }

        }
    }

    interface Iworker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : Iworker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Worker : Iworker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }

    }

    class Robot : Iworker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
