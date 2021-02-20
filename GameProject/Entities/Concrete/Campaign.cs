using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities.Concrete
{
    public class Campaign
    {
        public int CampaingId { get; set; }
        public string CampaingName { get; set; }
        public decimal DiscountRate { get; set; }
    }
}
