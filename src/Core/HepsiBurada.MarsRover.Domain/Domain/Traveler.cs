using HepsiBurada.MarsRover.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MarsRover.Domain.Domain
{
    public class Traveler
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Direction { get; set; }
        public Traveler(int x, int y, string direction)
        {
            this.X = x;
            this.Y = y;
            this.Direction = direction;
        }
    }
}
