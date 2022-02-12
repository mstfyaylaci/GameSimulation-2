using GameSimulation.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Abstract
{
  public  interface IPlayerCheckService
    {
        public bool CheckIfReelPerson(Player player);
    }
}
