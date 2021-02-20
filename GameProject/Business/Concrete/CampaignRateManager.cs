using GameProject.Business.Abstract;
using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete
{
    class CampaignRateManager : ICampaignRateService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaingName + " " + "isimli kampanya eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaingName + " " + "isimli kampanya silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaingName + " " + "isimli kampanya güncellendi.");
        }
    }
}
