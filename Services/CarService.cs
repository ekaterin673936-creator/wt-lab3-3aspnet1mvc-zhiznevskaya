using WtLab3Mvc.Models;

namespace WtLab3Mvc.Services;

public class CarService : ICarService
{
    private readonly List<Car> _cars = new()
    {
        new Sedan(1, "Toyota", "Camry", 2022, 5000m),
        new SUV(2, "BMW", "X5", 2023, 12000m),
        new Truck(3, "Volvo", "FH16", 2021, 18000m, 20m),
        new Sedan(4, "Kia", "Rio", 2021, 3500m),
        new SUV(5, "Mercedes-Benz", "GLE", 2024, 15000m),
    };

    public IEnumerable<Car> GetAll() => _cars;

    public Car? GetById(int id) => _cars.FirstOrDefault(c => c.Id == id);

    public void Add(Car car)
    {
        int newId = _cars.Count == 0 ? 1 : _cars.Max(c => c.Id) + 1;
        typeof(BaseEntity).GetProperty("Id")!.SetValue(car, newId);
        _cars.Add(car);
    }

    public bool Remove(int id)
    {
        var car = _cars.FirstOrDefault(c => c.Id == id);
        if (car == null) return false;
        return _cars.Remove(car);
    }
}