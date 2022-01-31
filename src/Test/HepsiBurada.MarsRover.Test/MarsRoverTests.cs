using HepsiBurada.MarsRover.Application.Features.CQRS;
using HepsiBurada.MarsRover.Domain.Domain;
using Xunit;

namespace HepsiBurada.MarsRover.Test
{
    public class MarsRoverTests
    {
        private readonly MarsRoverCommandHandler commandHandler;
        public MarsRoverTests()
        {
            commandHandler = new MarsRoverCommandHandler();
        }
        [Theory]
        [InlineData(new object[] { 5, 5, 1, 2, "N", new char[] { 'L','M','L','M','L','M','L','M','M' }, 1, 3,"N"})]
        [InlineData(new object[] { 5, 5, 3, 3, "E", new char[] { 'M', 'M', 'R', 'M', 'M', 'R', 'M', 'R', 'R','M' }, 5, 1, "E" })]
        public void CommandHandler_SampleValues_NoReturn(int plateX, int plateY, int travelerX, int travelerY, string travelerDirection, char[] travelerGestures, int expectedTravelerX, int expectedTravelerY, string expectedTravelerDirection)
        {

            Traveler traveler = new Traveler(travelerX, travelerY, travelerDirection);
            commandHandler.Handle(new MarsRoverCommand(travelerGestures, traveler, plateX, plateY));

            Assert.Equal(expectedTravelerY, traveler.Y);
            Assert.Equal(expectedTravelerX, traveler.X);
            Assert.Equal(expectedTravelerDirection,traveler.Direction);
        }
    }
}