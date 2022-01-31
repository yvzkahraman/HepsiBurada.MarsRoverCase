using HepsiBurada.MarsRover.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MarsRover.Application.Abstraction.MarsRoverEngine
{
    public abstract class MarsRoverEngineProcessBase
    {
        protected MarsRoverEngineProcessBase(int plateX, int plateY)
        {
            PlateX = plateX;
            PlateY = plateY;
        }

        public int PlateX { get; set; }

        public int PlateY { get; set; }


        public abstract void Process(Traveler traveler);
    }
}
