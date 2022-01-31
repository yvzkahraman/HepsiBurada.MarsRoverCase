using HepsiBurada.MarsRover.Application.Abstraction.States;
using HepsiBurada.MarsRover.Domain.Domain;

namespace HepsiBurada.MarsRover.Application.Features.States
{
    public class RightDirectionState : DirectionState
    {
        public override void Handle(Traveler traveler)
        {

            if (traveler.Direction == "N")
            {
                traveler.Direction = "E";
            }
            else if (traveler.Direction == "E")
            {
                //return new DirectionObject("S");
                traveler.Direction = "S";
            }
            else if (traveler.Direction == "S")
            {
                //return new DirectionObject("W");
                traveler.Direction = "W";
            }
            else
            {
                traveler.Direction = "N";
                //return new DirectionObject("N");
            }
        }
    }
}
