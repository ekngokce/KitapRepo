using Microsoft.AspNetCore.Mvc;

public class KitapController : Controller
{
    public ActionResult Index()
    {
        // Örnek bir kitap oluşturuyoruz
        var kitap = new Kitap
        {
            KitapAdi = "Yüzüklerin Efendisi",
            YazarAdi = "J.R.R. Tolkien",
            YayinlanmaTarihi = new DateTime(1954, 7, 29),
            Turu = "Fantastik",
            SayfaSayisi = 1178,
            Fiyat = 39.99m
        };

        // View katmanına kitabı gönderiyoruz
        return View(kitap);
    }
}
