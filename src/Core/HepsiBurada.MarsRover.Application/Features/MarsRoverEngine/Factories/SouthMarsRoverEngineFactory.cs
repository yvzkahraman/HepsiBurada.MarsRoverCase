using HepsiBurada.MarsRover.Application.Abstraction.MarsRoverEngine;
using HepsiBurada.MarsRover.Application.Features.MarsRoverEngine.Processes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MarsRover.Application.Features.MarsRoverEngine.Factories
{
    public class SouthMarsRoverEngineFactory : MarsRoverEngineBaseFactory
    {
        public override MarsRoverEngineProcessBase CreateProcess(int plateX, int plateY)
        {
            return new SouthMarsRoverEngineProcess(plateX, plateY); 
        }
    }
}
