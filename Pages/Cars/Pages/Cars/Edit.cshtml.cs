using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WtLab3Mvc.Models;
using WtLab3Mvc.Services;

namespace WtLab3Mvc.Pages.Cars;

public class EditModel : PageModel
{
    private readonly ICarService _carService;

    public EditModel(ICarService carService) { _carService = carService; }

    [BindProperty]
    public CarCreateModel Form { get; set; } = new();

    public IActionResult OnGet(int id)
    {
        var car = _carService.GetById(id);
        if (car == null) return NotFound();

        Form.Brand = car.Brand;
        Form.Model = car.Model;
        Form.Year = car.Year;
        Form.PricePerDay = car.PricePerDay;
        return Page();
    }

    public IActionResult OnPost(int id)
    {
        if (!ModelState.IsValid) return Page();

        var car = _carService.GetById(id);
        if (car == null) return NotFound();

        car.Brand = Form.Brand;
        car.Model = Form.Model;
        car.Year = Form.Year;
        car.UpdatePrice(Form.PricePerDay);

        return RedirectToPage("Index");
    }
}