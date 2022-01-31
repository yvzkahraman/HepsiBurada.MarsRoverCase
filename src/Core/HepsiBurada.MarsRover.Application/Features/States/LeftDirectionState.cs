using HepsiBurada.MarsRover.Application.Abstraction.States;
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
            if (traveler.Direction == "N")
            {
                //gezdiziDirectionState = "W";
                traveler.Direction = "W";
            }
            else if (traveler.Direction == "W")
            {
                traveler.Direction = "S";
            }
            else if (traveler.Direction == "S")
            {
                //gezdiziDirectionState = "E";
                traveler.Direction = "E";
            }
            else
            {
                //gezdiziDirectionState = "N";
                traveler.Direction = "N";
            }
        }
    }
}
