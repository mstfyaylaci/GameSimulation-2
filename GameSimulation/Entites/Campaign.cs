using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Entites
{
    public class Campaign
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }

        public double UnitPrice { get; set; }
        public double DiscountedPrice { get; set; }
    }
}
