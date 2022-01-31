using HepsiBurada.MarsRover.Application.Features.MarsRoverEngine;
using HepsiBurada.MarsRover.Application.Features.MarsRoverEngine.Factories;
using HepsiBurada.MarsRover.Application.Features.States;
using HepsiBurada.MarsRover.Domain.ConstValues;
using HepsiBurada.MarsRover.Domain.Domain;
using HepsiBurada.MarsRover.Domain.Enums;

namespace HepsiBurada.MarsRover.Application.Features.CQRS
{
    public class MarsRoverCommand
    {
        public MarsRoverCommand(char[] travelerGestures, Traveler traveler, int plateX, int plateY)
        {
            TravelerGestures = travelerGestures;
            Traveler = traveler;
            PlateX = plateX;
            PlateY = plateY;
        }

        public char[] TravelerGestures { get; set; }
        public Traveler Traveler { get; set; }

        public int PlateX { get; set; }

        public int PlateY { get; set; }
    }

    public class MarsRoverCommandHandler
    {
        public void Handle(MarsRoverCommand command)
        {
            if (command.TravelerGestures != null)
            {
                foreach (var gesture in command.TravelerGestures)
                {
                    if (gesture == ActionValue.Left)
                    {
                        if (command.Traveler != null)
                        {
                            new DirectionStateContext(new LeftDirectionState()).Handle(command.Traveler);
                        }
                    }
                    else if (gesture == ActionValue.Right)
                    {
                        if (command.Traveler != null)
                        {
                            new DirectionStateContext(new RightDirectionState()).Handle(command.Traveler);

                        }

                    }

                    else if (gesture == ActionValue.Move)
                    {
                        if (command.Traveler?.Direction == DirectionValue.East)
                        {
                            new MarsRoverEngineDirector(new EastMarsRoverEngineFactory(), command.PlateX, command.PlateY).Process(command.Traveler);

                        }

                        else if (command.Traveler?.Direction == DirectionValue.North)
                        {
                            new MarsRoverEngineDirector(new NorthMarsRoverEngineFactory(), command.PlateX, command.PlateY).Process(command.Traveler);
                        }
                        else if (command.Traveler?.Direction == DirectionValue.South)
                        {
                            new MarsRoverEngineDirector(new SouthMarsRoverEngineFactory(), command.PlateX, command.PlateY).Process(command.Traveler);
                        }
                        else if (command.Traveler?.Direction == DirectionValue.West)
                        {
                            new MarsRoverEngineDirector(new WestMarsRoverEngineFactory(), command.PlateX, command.PlateY).Process(command.Traveler);
                        }
                    }
                }
            }
        }
    }
}
