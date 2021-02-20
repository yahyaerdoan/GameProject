using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Abstract
{
    public interface ISalesService
    {
        void Sales(Gamer gamer, Game game);
        void CampaignSales(Game game, Gamer gamer, Campaign campaign);
        
    }
}
