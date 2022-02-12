using GameSimulation.Abstract;
using GameSimulation.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Concretes
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("kampanya eklendi :"+campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("kampanya silindi :" + campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("kampanya güncellendi :" + campaign.CampaignName);
        }
    }
}
