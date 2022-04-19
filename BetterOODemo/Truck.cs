// See https://aka.ms/new-console-template for more information

using BetterOODemo;

public class Truck : LandVehicle, IRental
{
    public TruckType Style { get; set; }
    public int RentalId { get; set; }
    public string CurrentRenter { get; set; }
    public decimal PricePerday { get; set; }
}