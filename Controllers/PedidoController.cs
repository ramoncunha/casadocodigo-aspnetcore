using Microsoft.AspNetCore.Mvc;

namespace mvc_alura.Controllers
{
    public class PedidoController : Controller
    {
        public IActionResult Carrossel()
        {
            return View("Carrossel");
        }

        public IActionResult Carrinho()
        {
            return View();
        }

        public IActionResult Resumo()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
