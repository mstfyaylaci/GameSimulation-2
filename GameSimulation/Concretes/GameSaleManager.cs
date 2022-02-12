using GameSimulation.Abstract;
using GameSimulation.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Concretes
{
    class GameSaleManager : IGameSaleService
    {
        public void GameSale(Game game, Campaign campaign, Player player)
        {
            Console.WriteLine(game.GameName+"oyunu "+campaign.CampaignName+"kampanyası ile "+player.Firstname+"oyuncusuna satıldı " );
        }
    }
}
