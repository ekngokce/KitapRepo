using Microsoft.AspNetCore.Mvc;

public class KitapController : Controller
{
    public ActionResult Index()
    {
        
        var kitap = new Kitap
        {
            KitapAdi = "Yüzüklerin Efendisi",
            YazarAdi = "J.R.R. Tolkien",
            YayinlanmaTarihi = new DateTime(1954, 7, 29),
            Turu = "Fantastik",
            SayfaSayisi = 1178,
            Fiyat = 39.99tl
        };

        
        return View(kitap);
    }
}
