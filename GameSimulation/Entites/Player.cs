using GameSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Entites
{
    public class Player : IEntity
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }

        public string NationalityId { get; set; }
        public long DateOfBirth { get; set; }
    }
}
