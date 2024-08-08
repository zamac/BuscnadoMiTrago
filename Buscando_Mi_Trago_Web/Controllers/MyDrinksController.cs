using Microsoft.AspNetCore.Mvc;

namespace Buscando_Mi_Trago_Web.Controllers
{
    public class MyDrinksController : Controller
    {
        public IActionResult MyList()
        {
            return View();
        }
    }
}
