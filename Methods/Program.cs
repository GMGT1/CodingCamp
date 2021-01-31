using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();

            Console.WriteLine("-----------------");

            //Console.WriteLine(Add2(5, 6)); 

            //var result = Add2(5, 6);
            //Console.WriteLine(result + 25);

            //int sayi1;
            //var result2 = Add2(out sayi1);
            //Console.WriteLine(result2);

            //Console.WriteLine(sayi1);

            //Console.WriteLine(Multiply(5, 3));
            //Console.WriteLine(Multiply(2, 3, 9));
            Console.WriteLine(Add4(1,2,3,4,5,6,9,15));

        }


        static void Add()
        {
            Console.WriteLine("Added!");

        }

        static int Add2(out int sayi1, int sayi2 = 9)
        {
            sayi1 = 8;
            var result = sayi1 + sayi2;
            return result;
        }

            
        static int Multiply(int sayi1, int sayi2)
        {
                return sayi1 * sayi2;
        }

        static int Multiply(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 * sayi2 * sayi3;
        }


        static int Add4(params int[] numbers)
        {
            //return numbers.Sum();
            int R = 0;
            for (int i=0 ; i<numbers.Length ; i++)
            {
                R += numbers[i];
                
            }
            return R;

        }

    } 

}
