using GameSimulation.Abstract;
using GameSimulation.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Concretes
{
    class PlayerManager : IPlayerService
    {
        private IPlayerCheckService _playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }
        public void Add(Player player)
        {
            if (_playerCheckService.CheckIfReelPerson(player)==true)
            {
                Console.WriteLine(player.Firstname+" "+ player.LastName +" "+ "adlı oyuncu başarılı şekilde kaydedildi");
            }
            else
            {
                Console.WriteLine("kayıt başarısız");
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.Firstname + ": Oyuncu başarı ile silindi");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.Firstname + ": Oyuncu başarı ile güncellendi");
        }
    }
}
