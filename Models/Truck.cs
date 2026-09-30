namespace WtLab3Mvc.Models;

public class Truck : Car
{
    public decimal LoadCapacityTons { get; set; }

    public Truck() { }

    public Truck(int id, string brand, string model, int year, decimal pricePerDay, decimal loadTons)
        : base(id, brand, model, year, pricePerDay)
    {
        LoadCapacityTons = loadTons;
        VehicleType = "Truck";
    }
}