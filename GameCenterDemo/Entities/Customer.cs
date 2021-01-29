using GameCenterDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenterDemo.Entities
{
   public class Customer:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NatioalityId { get; set; }
        public DateTime DateofBirth { get; set; }
    }
}
