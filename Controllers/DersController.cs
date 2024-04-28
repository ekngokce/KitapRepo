using Microsoft.AspNetCore.Mvc;

public class DersController : Controller
{
    public IActionResult Index()
    {
        Ders ders = new Ders
        {
            Ad = "ASP.NET MVC",
            Seviye = "Orta",
            Öğretmen = "Ahmet Öğretmen"
        };

        return View(ders);
    }
}