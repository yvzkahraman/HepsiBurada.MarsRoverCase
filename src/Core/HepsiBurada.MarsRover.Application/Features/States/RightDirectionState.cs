using HepsiBurada.MarsRover.Application.Abstraction.States;
using HepsiBurada.MarsRover.Domain.ConstValues;
using HepsiBurada.MarsRover.Domain.Domain;

namespace HepsiBurada.MarsRover.Application.Features.States
{
    public class RightDirectionState : DirectionState
    {
        public override void Handle(Traveler traveler)
        {

            switch (traveler.Direction)
            {
                case DirectionValue.North:
                    traveler.Direction = DirectionValue.East;
                    break;
                case DirectionValue.East:
                    traveler.Direction = DirectionValue.South;
                    break;
                case DirectionValue.South:
                    traveler.Direction = DirectionValue.West;
                    break;
                default:
                    traveler.Direction = DirectionValue.North;
                    break;
            }
        }
    }
}
