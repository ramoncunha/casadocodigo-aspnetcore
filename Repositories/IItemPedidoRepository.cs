using Alura_CasaDoCodigo.Models;

namespace Alura_CasaDoCodigo.Repositories
{
    public interface IItemPedidoRepository
    {
        ItemPedido GetItemPedidoId(int itemPedidoId);
        void RemoveItemPedido(int itemPedidoId);
    }
}