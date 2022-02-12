using GameSimulation.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Abstract
{
    public interface IGameSaleService
    {
        void GameSale(Game game,Campaign campaign,Player player);
    }
}
