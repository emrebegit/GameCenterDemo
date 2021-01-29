using GameCenterDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenterDemo.Entities
{
    public class Sales:IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Piece { get; set; }
        public int TotalAmount { get; set; }
    }
}
