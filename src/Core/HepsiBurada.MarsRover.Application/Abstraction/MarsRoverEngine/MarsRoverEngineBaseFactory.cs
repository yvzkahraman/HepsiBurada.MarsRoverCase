using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MarsRover.Application.Abstraction.MarsRoverEngine
{
    public abstract class MarsRoverEngineBaseFactory
    {
        public abstract MarsRoverEngineProcessBase CreateProcess(int plateX, int plateY);
    }
}