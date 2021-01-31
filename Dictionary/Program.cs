using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Dictionary sınıfı içinde sizin belirleyeceğiniz bir key'e uygun değer saklar.
             * key türünü belirlememiz şarttır (string, int vs...)
             */
            Dictionary<string, int> AdYas = new Dictionary<string, int>();
            // veri ekliyoruz
            AdYas.Add("Amy", 25);
            AdYas.Add("Mehmet", 17);
            AdYas.Add("Lelusch", 30);

            foreach (var kisi in AdYas)
            {
                Console.WriteLine(kisi);
            }
            // Değer sayma özelliği vardır.

            var eleman = AdYas.Count;
            Console.WriteLine("eleman sayısı", eleman);

            //silme özelliği vardır.
            AdYas.Remove("Mehmet");
            foreach (var kisi in AdYas)
            {
                Console.WriteLine(kisi.Key);
            }


        }
    }   
}
