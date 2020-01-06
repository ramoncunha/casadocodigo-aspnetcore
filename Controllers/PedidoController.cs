using Alura_CasaDoCodigo.Models;
using Alura_CasaDoCodigo.Models.ViewModels;
using Alura_CasaDoCodigo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace mvc_alura.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IProdutoRepository produtoRepository;
        private readonly IPedidoRepository pedidoRepository;
        private readonly IItemPedidoRepository itemPedidoRepository;

        public PedidoController(IProdutoRepository produtoRepository,
            IPedidoRepository pedidoRepository, IItemPedidoRepository itemPedidoRepository)
        {
            this.produtoRepository = produtoRepository;
            this.pedidoRepository = pedidoRepository;
            this.itemPedidoRepository = itemPedidoRepository;
        }

        public IActionResult Carrossel()
        {
            return View(produtoRepository.GetProdutos());
        }

        public IActionResult Carrinho(string codigo)
        {
            if (!string.IsNullOrEmpty(codigo))
            {
                pedidoRepository.AddItem(codigo);
            }
            Pedido pedido = pedidoRepository.GetPedido();
            var viewModel = new CarrinhoViewModel(pedido.Itens);
            return View(viewModel);
        }

        public IActionResult Resumo()
        {
            Pedido pedido = pedidoRepository.GetPedido();
            return View(pedido);
        }

        public IActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public void UpdateQuantidade([FromBody]ItemPedido itemPedido)
        {
            itemPedidoRepository.UpdateQuantidade(itemPedido);
        }
    }
}
