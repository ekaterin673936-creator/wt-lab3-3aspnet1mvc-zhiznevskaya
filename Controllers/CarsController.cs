using Microsoft.AspNetCore.Mvc;
using WtLab3Mvc.Models;
using WtLab3Mvc.Services;

namespace WtLab3Mvc.Controllers;

public class CarsController : Controller
{
    private readonly ICarService _carService;

    public CarsController(ICarService carService)
    {
        _carService = carService;
    }

    // GET: /Cars
    public IActionResult Index()
    {
        return View(_carService.GetAll());
    }

    // GET: /Cars/Details/5
    public IActionResult Details(int id)
    {
        var car = _carService.GetById(id);
        if (car == null)
            return NotFound();
        return View(car);
    }

    // GET: /Cars/Create — показать форму
    public IActionResult Create()
    {
        return View();
    }

    // POST: /Cars/Create — принять данные формы и добавить автомобиль
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(CarCreateModel form)
    {
        if (!ModelState.IsValid)
            return View(form);

        var car = new Sedan(0, form.Brand, form.Model, form.Year, form.PricePerDay);
        _carService.Add(car);
        return RedirectToAction(nameof(Index));
    }
}