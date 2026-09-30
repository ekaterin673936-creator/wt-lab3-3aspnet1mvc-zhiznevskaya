using Microsoft.AspNetCore.Mvc.RazorPages;
using WtLab3Mvc.Models;
using WtLab3Mvc.Services;

namespace WtLab3Mvc.Pages.Cars;

public class IndexModel : PageModel
{
    private readonly ICarService _carService;

    // DI: сервис приходит через конструктор PageModel
    public IndexModel(ICarService carService)
    {
        _carService = carService;
    }

    public IEnumerable<Car> Cars { get; set; } = new List<Car>();

    // OnGet вызывается при GET-запросе к странице
    public void OnGet()
    {
        Cars = _carService.GetAll();
    }
}