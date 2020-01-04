using Alura_CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura_CasaDoCodigo.Repositories
{
    public class PedidoRepository : BaseRepository<Pedido>
    {
        public PedidoRepository(ApplicationContext contexto) : base(contexto)
        {
        }


    }
}
