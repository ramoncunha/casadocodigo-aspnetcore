using Alura_CasaDoCodigo.Models;
using System.Linq;

namespace Alura_CasaDoCodigo.Repositories
{
    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public ItemPedido GetItemPedidoId(int itemPedidoId)
        {
            return dbSet
                    .Where(ip => ip.Id == itemPedidoId)
                    .SingleOrDefault();
        }

        public void RemoveItemPedido(int itemPedidoId)
        {
            var itemRemovivel = GetItemPedidoId(itemPedidoId);
            dbSet.Remove(itemRemovivel);
        }
    }
}
