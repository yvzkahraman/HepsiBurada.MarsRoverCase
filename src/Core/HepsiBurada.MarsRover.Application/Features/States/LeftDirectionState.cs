using HepsiBurada.MarsRover.Application.Abstraction.States;
using HepsiBurada.MarsRover.Domain.ConstValues;
using HepsiBurada.MarsRover.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MarsRover.Application.Features.States
{
    public class LeftDirectionState : DirectionState
    {
        public override void Handle(Traveler traveler)
        {
            switch (traveler.Direction)
            {
                case DirectionValue.North:
                    traveler.Direction = DirectionValue.West;
                    break;
                case DirectionValue.West:
                    traveler.Direction = DirectionValue.South;
                    break;
                case DirectionValue.South:
                    traveler.Direction = DirectionValue.East;
                    break;
                default:
                    traveler.Direction = DirectionValue.North;
                    break;
            }
        }
    }
}
