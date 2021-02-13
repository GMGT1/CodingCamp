using GameWork.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWork.Abstract
{
    public abstract class BaseCampaignManager : ICampaignService
    {
        public void AddCampaign()
        {
            Console.WriteLine("KAMPANYA BAŞLADI - ! TÜM ÜRÜNLERDE %50 İNDİRİM !");
        }

        public void DelCampaign()
        {
            Console.WriteLine("Kampanyanın süresi doldu.");
        }

        public void UpdateCampaign()
        {
            Console.WriteLine("KAMPANYA YENİLENDİ ! - !!! TÜM ÜRÜNLERDE %90'A VARAN İNDİRİM !!!");
        }

        public abstract void PersonalDiscount(Customer customer);


    }
}
