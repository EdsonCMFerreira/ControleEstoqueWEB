using Microsoft.AspNetCore.Mvc;

namespace ControleEstoque.WEB.Controllers
{
    public class GraficoController : Controller
    {
        public IActionResult Grafico()
        {
            return View();
        }

        public IActionResult EntradaSaidaMes()
        {
            return View();
        }

    }
}
