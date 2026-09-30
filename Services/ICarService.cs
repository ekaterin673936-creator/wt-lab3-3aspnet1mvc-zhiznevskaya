using WtLab3Mvc.Models;

namespace WtLab3Mvc.Services;

public interface ICarService
{
    IEnumerable<Car> GetAll();
    Car? GetById(int id);
    void Add(Car car);
    bool Remove(int id);
}