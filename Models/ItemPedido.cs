using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura_CasaDoCodigo.Models
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public Pedido Pedido { get; private set; }
        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }
        public decimal PrecoUnitario { get; private set; }

        public ItemPedido()
        {

        }

        public ItemPedido(Pedido pedido, Produto produto, int quantidade, decimal precoUnitario)
        {
            Pedido = pedido;
            Produto = produto;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
        }
    }
}
