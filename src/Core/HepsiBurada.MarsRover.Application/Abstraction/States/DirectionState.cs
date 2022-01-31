using HepsiBurada.MarsRover.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MarsRover.Application.Abstraction.States
{
    public abstract class DirectionState
    {
        public abstract void Handle(Traveler traveler);
    }
}
