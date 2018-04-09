using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public partial class Move
    {
        public int QuantityProbes { get; set; }
        public string SizeOfArea { get; set; }
        public string PositionStartA { get; set; }
        public string DirectionsMoveA { get; set; }
        public string PositionStartB { get; set; }
        public string DirectionsMoveB { get; set; }

    }

    public partial class MoveMongo
    {
        public DateTime Date { get; set; }
        public string SizeOfArea { get; set; }
        public string PositionStartA { get; set; }
        public string DirectionsMoveA { get; set; }
        public string PositionStartB { get; set; }
        public string DirectionsMoveB { get; set; }
        public string ResultA { get; set; }
        public string ResultB { get; set; }
    }
}