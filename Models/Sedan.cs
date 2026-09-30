namespace WtLab3Mvc.Models;

public class Sedan : Car
{
    public int Seats { get; set; } = 5;

    public Sedan() { }

    public Sedan(int id, string brand, string model, int year, decimal pricePerDay, int seats = 5)
        : base(id, brand, model, year, pricePerDay)
    {
        Seats = seats;
        VehicleType = "Sedan";
    }
}