// See https://aka.ms/new-console-template for more information

using BetterOODemo;

public class Car : LandVehicle, IRental
{
    public CarType Style { get; set; }
    public int RentalId { get; set; }
    public string CurrentRenter { get; set; }
    public decimal PricePerday { get; set; }
}