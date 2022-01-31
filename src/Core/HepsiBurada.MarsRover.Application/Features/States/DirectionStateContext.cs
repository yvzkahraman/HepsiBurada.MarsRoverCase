using HepsiBurada.MarsRover.Application.Abstraction.States;
using HepsiBurada.MarsRover.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MarsRover.Application.Features.States
{
    public class DirectionStateContext
    {
        private readonly DirectionState directionState;
        public DirectionStateContext(DirectionState directionState)
        {
            this.directionState = directionState;
        }
        public void Handle(Traveler traveler)
        {
            this.directionState.Handle(traveler);
        }
    }
}
