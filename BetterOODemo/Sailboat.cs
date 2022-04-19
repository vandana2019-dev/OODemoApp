// See https://aka.ms/new-console-template for more information

using BetterOODemo;
// We did not inherit from the class LandVehicle
public class Sailboat : IRental
{
    public int RentalId { get; set; }
    public string CurrentRenter { get; set; }
    public decimal PricePerday { get; set; }
}