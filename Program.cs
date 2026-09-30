using WtLab3Mvc.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ICarService, CarService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

// ВАЖНО: подключаем Razor Pages
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

// ВАЖНО: подключаем маршрутизацию Razor Pages
app.MapRazorPages();

app.Run();