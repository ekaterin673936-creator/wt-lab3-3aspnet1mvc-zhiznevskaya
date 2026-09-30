using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WtLab3Mvc.Models;
using WtLab3Mvc.Services;

namespace WtLab3Mvc.Pages.Cars;

public class DeleteModel : PageModel
{
    private readonly ICarService _carService;

    public DeleteModel(ICarService carService) { _carService = carService; }

    public Car? Car { get; set; }

    public IActionResult OnGet(int id)
    {
        Car = _carService.GetById(id);
        if (Car == null) return NotFound();
        return Page();
    }

    public IActionResult OnPost(int id)
    {
        _carService.Remove(id);
        return RedirectToPage("Index");
    }
}