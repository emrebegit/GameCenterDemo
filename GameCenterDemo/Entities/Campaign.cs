using GameCenterDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenterDemo.Entities
{
   public class Campaign:IEntity
    {
        public int Id { get; set; }
        public float Percent { get; set; }
    }
}
