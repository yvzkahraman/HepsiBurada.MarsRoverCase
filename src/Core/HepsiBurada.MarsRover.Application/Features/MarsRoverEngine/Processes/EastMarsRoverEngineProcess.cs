﻿using HepsiBurada.MarsRover.Application.Abstraction.MarsRoverEngine;
using HepsiBurada.MarsRover.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MarsRover.Application.Features.MarsRoverEngine.Processes
{
    public class EastMarsRoverEngineProcess : MarsRoverEngineProcessBase
    {
        public EastMarsRoverEngineProcess(int plateX, int plateY) : base(plateX, plateY)
        {
        }

        public override void Process(Traveler traveler)
        {
            if (traveler.X < PlateX)
            {
                traveler.X++;
            }
        }
    }
}
