using GameProject.Business.Abstract;
using GameProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete
{
    public class SalesManager : ISalesService
    {
        public void CampaignSales(Game game, Gamer gamer, Campaign campaign)
        {
            decimal discountedSales = game.GamePrice - (game.GamePrice * campaign.DiscountRate);
            Console.WriteLine(game.GameName + " isimli oyun " + gamer.FirstName + " " + gamer.LastName+ " isimli kullanıcıya " + campaign.CampaingName
                + " kampanyası ile " + discountedSales + " TL " + " fiyatla satıldı");
        }

        public void Sales(Gamer gamer, Game game)
        {
            Console.WriteLine(game.GameName + " isimli oyun " + gamer.FirstName + " " + gamer.LastName 
                + " isimli kullanıcıya " + game.GamePrice + " TL " + " fiyatla satıldı");
        }
              
    }
}
