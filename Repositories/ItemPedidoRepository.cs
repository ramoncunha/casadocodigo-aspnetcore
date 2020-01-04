using Alura_CasaDoCodigo.Models;
using System.Linq;

namespace Alura_CasaDoCodigo.Repositories
{
    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public void UpdateQuantidade(ItemPedido itemPedido)
        {
            var itemPedidoDB = dbSet
                .Where(ip => ip.Id == itemPedido.Id)
                .SingleOrDefault();

            if (itemPedidoDB != null)
            {
                itemPedidoDB.AtualizaQuantidade(itemPedido.Quantidade);
                contexto.SaveChanges();
            }
        }
    }
}
