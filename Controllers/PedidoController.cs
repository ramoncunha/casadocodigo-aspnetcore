using Alura_CasaDoCodigo.Models;
using Alura_CasaDoCodigo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace mvc_alura.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IProdutoRepository produtoRepository;
        private readonly IPedidoRepository pedidoRepository;

        public PedidoController(IProdutoRepository produtoRepository,
            IPedidoRepository pedidoRepository)
        {
            this.produtoRepository = produtoRepository;
            this.pedidoRepository = pedidoRepository;
        }

        public IActionResult Carrossel()
        {
            return View(produtoRepository.GetProdutos());
        }

        public IActionResult Carrinho()
        {
            Pedido pedido = pedidoRepository.GetPedido();
            return View(pedido.Itens);
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
