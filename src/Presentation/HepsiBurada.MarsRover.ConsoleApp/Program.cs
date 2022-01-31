// See https://aka.ms/new-console-template for more information

using HepsiBurada.MarsRover.Application.Features.CQRS;
using HepsiBurada.MarsRover.Domain.Domain;

Console.Write("Platonun üst konum bilgisini giriniz:");
var plateXY = Console.ReadLine();

var plateXYArray = plateXY?.Split(' ');
if (plateXYArray != null)
{

    var plateX = int.Parse(plateXYArray[0]);
    var plateY = int.Parse(plateXYArray[1]);
    Console.WriteLine("Platonun X konumu :" + plateX + " Platonun Y konumu :" + plateY);

    Console.Write("Gezginin konumunu giriniz:");
    var travelerLocation = Console.ReadLine();
    var travelerLocationArray = travelerLocation?.Split(' ');
    if (travelerLocationArray != null)
    {
        
        var travelerX = travelerLocationArray[0];
        var travelerY = travelerLocationArray[1];
        var travelerDirection = travelerLocationArray[2];

        var traveler = new Traveler(int.Parse(travelerX), int.Parse(travelerY), travelerDirection);
        Console.WriteLine("Gezginin x konumu :" + travelerX + " gezginin Y konumu:" + travelerY + " gezginin yönü :" + travelerDirection);

        Console.Write("Gezginin hareketlerini giriniz:");
        var gestureString = Console.ReadLine();

        if(gestureString != null)
        {
            new MarsRoverCommandHandler().Handle(new MarsRoverCommand(gestureString.ToCharArray(), traveler, plateX, plateY));
        }


        Console.WriteLine("Gezgincinin mevcut X konumu :" + traveler.X + "\nGezgincinin mevcut Y konumu :" + traveler.Y + "\nGezgincinin yönü :" + traveler.Direction);
    }
}
else
{
    Console.WriteLine("Girdiğiniz datalar arasında boşluk olmalı");
}

Console.WriteLine("Hello, World!");
