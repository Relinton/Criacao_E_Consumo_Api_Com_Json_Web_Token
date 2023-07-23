using Microsoft.AspNetCore.Mvc;

namespace Consumo_Api_Jwt.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult BuscaTodos()
        {
            return View();
        }
    }
}
