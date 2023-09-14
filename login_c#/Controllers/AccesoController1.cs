using Microsoft.AspNetCore.Mvc;

namespace login_c_.Controllers
{
    public class AccesoController1 : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Registrar()
        {
            return View();
        }

    }
}
