using GameSimulation.Abstract;
using GameSimulation.Adapters;
using GameSimulation.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Concretes
{
    public class PlayerCheckManager : IPlayerCheckService
    {
        IPlayerCheckService playerCheckService;
        public bool CheckIfReelPerson(Player player)
        {
            playerCheckService = new MernisServiceAdapters();
            return playerCheckService.CheckIfReelPerson(player);
        }
    }
}
