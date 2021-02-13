using GameWork.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWork.Abstract
{
    public interface ICampaignService
    {
        void AddCampaign();
        void DelCampaign();
        void UpdateCampaign();
    }
}
