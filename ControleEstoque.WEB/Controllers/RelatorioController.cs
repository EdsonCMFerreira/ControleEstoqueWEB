using Microsoft.AspNetCore.Mvc;

namespace ControleEstoque.WEB.Controllers
{
    public class RelatorioController : Controller
    {
        public IActionResult PosicaoEstoque()
        {
            return View();
        }

        public IActionResult Ressuprimento()
        {
            return View();
        }

    }
}
