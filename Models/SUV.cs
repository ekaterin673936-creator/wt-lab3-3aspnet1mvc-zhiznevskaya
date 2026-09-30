namespace WtLab3Mvc.Models;

public class SUV : Car
{
    public bool IsAllWheelDrive { get; set; } = true;

    public SUV() { }

    public SUV(int id, string brand, string model, int year, decimal pricePerDay, bool awd = true)
        : base(id, brand, model, year, pricePerDay)
    {
        IsAllWheelDrive = awd;
        VehicleType = "SUV";
    }
}