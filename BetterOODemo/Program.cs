// See https://aka.ms/new-console-template for more information

using BetterOODemo;

Console.WriteLine("Hello, World!");

List<IRental> rentals = new List<IRental>();

rentals.Add(new Truck() { CurrentRenter = "Truck Renter" });
rentals.Add(new Truck() { CurrentRenter = "Sailboat Renter" });
rentals.Add(new Car() { CurrentRenter = "Car Renter" });


foreach(var r in rentals)
{
    Console.WriteLine(r.CurrentRenter);

    if(r is Truck t)
    {
        Console.WriteLine(t.NumberOfPassengers);
    }
}
