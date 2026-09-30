namespace WtLab3Mvc.Models;

public class Car : BaseEntity
{
    private decimal _pricePerDay;

    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; }
    public decimal PricePerDay => _pricePerDay;
    protected string VehicleType { get; set; } = "Car";

    public Car() { }

    public Car(int id, string brand, string model, int year, decimal pricePerDay)
    {
        Id = id;
        Brand = brand;
        Model = model;
        Year = year;
        UpdatePrice(pricePerDay);
    }

    public void UpdatePrice(decimal newPrice)
    {
        if (newPrice <= 0)
            throw new ArgumentException("Цена должна быть больше нуля");
        _pricePerDay = newPrice;
    }

    public override void PrintInfo()
        => Console.WriteLine($"[{Id}] {Brand} {Model} {Year} | {PricePerDay:C}");
}