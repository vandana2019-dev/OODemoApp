// See https://aka.ms/new-console-template for more information
using OODemo;

/*
 *  Inheritance is not code-sharing , Is-a relationship
 *  Need to share common logic
 *  Sharing just properties or method signatures is not enough
 *  Inheritance can put you in a corner
 *  You need to ask the question : What is the point
 */

// Rental agency in Miami

// Initially it was only Rental Car, then later we have Rental Truck.
// Here we use inheritance 

// Create a base class , Rental Vehicle 

// Two child classes RentalCar and RentalTruck

public class RentalVehicle
{
    public int RentalId { get; set; }
    public string CurrentRenter { get; set; }

    public decimal PricePerday { get; set; }

    public int NumberOfPassengers { get; set; }

  
    public virtual void StartEngine()
    {
        Console.WriteLine("Turn key to ignition setting");
        Console.WriteLine("Turn key to on");
    }

    public virtual void StopEngine()
    {
        Console.WriteLine("Turn key to off"); 
    }
}