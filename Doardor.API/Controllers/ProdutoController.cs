using Microsoft.AspNetCore.Mvc;

namespace Doador.API.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
