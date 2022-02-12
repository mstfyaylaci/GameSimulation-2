using GameSimulation.Abstract;
using GameSimulation.Entites;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Adapters
{
    class MernisServiceAdapters : IPlayerCheckService
    {
        public bool CheckIfReelPerson(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();

            return client.TCKimlikNoDogrulaAsync((Convert.ToInt64(player.NationalityId),
                player.Firstname.ToUpper(), player.LastName.ToUpper(), player.DateOfBirth));
        }
    }
}
