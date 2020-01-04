using Alura_CasaDoCodigo.Models;

namespace Alura_CasaDoCodigo.Repositories
{
    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public void UpdateQuantidade(IItemPedidoRepository itemPedido)
        {
            
        }
    }
}
