
using GameProject.Business.Concrete;
using GameProject.Entities.Concrete;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new MernisUserValidationServiceManager());
            Gamer gamer = new Gamer();
            gamerManager.Add(new Gamer
            {
                GamerId = 1,
                DateOfBirth = new DateTime(1992,02,14),
                FirstName = "Yahya",
                LastName = "ERDOĞAN",
                IdentityNumber = 2
            });

            CampaignRateManager campaignRateManager = new CampaignRateManager();
            Campaign campaign = new Campaign { CampaingId = 1, CampaingName = "Eğlenceli %25 İndirim", DiscountRate = 0.25M };
            campaignRateManager.Add(campaign);

            GameManager gameManager = new GameManager();
            Game game = new Game { GameId = 1, GameName = "Minecraft", GamePrice = 145 };
            gameManager.Add(game);
           

            SalesManager salesManager = new SalesManager();            
            salesManager.Sales(gamer, game);
            salesManager.CampaignSales(game, gamer, campaign);

        }
    }
}
