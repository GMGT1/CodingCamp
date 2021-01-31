using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Costumer costumer1 = new Costumer();
            costumer1.Id = "DemirAdam";
            costumer1.Name = "Talha";
            costumer1.Surname = "Gamga";
            costumer1.CallNumber = "+908123654512";

            Costumer costumer2 = new Costumer();
            costumer2.Id = "DemirAdam2";
            costumer2.Name = "Baran";
            costumer2.Surname = "Gamga";
            costumer2.CallNumber = "+90624563258";

            Costumer costumer3 = new Costumer();
            costumer3.Id = "DemirAdam3";
            costumer3.Name = "Onur";
            costumer3.Surname = "Gamga";
            costumer3.CallNumber = "+909998887766";

            Costumer[] costumers = new Costumer[] { costumer1, costumer2, costumer3 };

            CostumerManager costumerManager = new CostumerManager();

            foreach (Costumer costumer in costumers)
            {
                costumerManager.AddCostumer(costumer);
            }

            Console.WriteLine("-------------------------------------------------");

            foreach (Costumer costumer in costumers)
            {
                costumerManager.ShowCostumer(costumer);
                Console.WriteLine("............................");
            }

            

        }
    }
}
