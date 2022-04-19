// See https://aka.ms/new-console-template for more information




/*
 *  Inheritance is not code-sharing , Is-a relationship
 *  Need to share common logic
 *  Sharing just properties or method signatures is not enough
 *  Inheritance can put you in a corner
 *  You need to ask the question : What is the point
 */

// Rental agency in Miami

// Initially it was only Rental Car, then later we have Rental Truck. Here we use inheritance 

// Create a base class , Rental Vehicle 

public class RentalBoat : RentalVehicle
{
    public override void StartEngine()
    {
        throw new Exception("I do not have an engine to start");
    }

    public override void StopEngine()
    {
        throw new Exception("I do not have an engine to stop");
    }
}