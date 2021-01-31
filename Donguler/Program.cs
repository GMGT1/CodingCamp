using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılımcı geliştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            //array 

            string[] kurslar = new string[] 
            {
            "Yazılımcı geliştirme kampı",
            "Programlamaya başlangıç için temel kurs",
            "Java",
            "Python",
            "C#"
            };


            for (int i = 0; i<5; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("---------------------------");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footar");
        }
    }
}
