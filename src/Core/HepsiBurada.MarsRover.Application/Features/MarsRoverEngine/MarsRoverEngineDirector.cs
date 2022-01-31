using HepsiBurada.MarsRover.Application.Abstraction.MarsRoverEngine;
using HepsiBurada.MarsRover.Domain.Domain;

namespace HepsiBurada.MarsRover.Application.Features.MarsRoverEngine
{
    public class MarsRoverEngineDirector
    {
        private readonly MarsRoverEngineBaseFactory marsRoverEngineFactory;
        private readonly MarsRoverEngineProcessBase marsRoverEngineProcess;

        public MarsRoverEngineDirector(MarsRoverEngineBaseFactory marsRoverEngineFactory, int plateX, int plateY)
        {
            this.marsRoverEngineFactory = marsRoverEngineFactory;
            this.marsRoverEngineProcess = this.marsRoverEngineFactory.CreateProcess(plateX, plateY);
        }

        public void Process(Traveler traveler)
        {
            this.marsRoverEngineProcess.Process(traveler);
        }
    }
}
