using Microsoft.AspNetCore.Mvc;

namespace ControleEstoque.WEB.Controllers
{
    public class OperacaoController : Controller
    {
        public IActionResult EntradaEstoque()
        {
            return View();
        }

        public IActionResult SaidaEstoque()
        {
            return View();
        }

        public IActionResult LancPerdaProduto()
        {
            return View();
        }

        public IActionResult Inventario()
        {
            return View();
        }



    }
}
