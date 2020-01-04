using Alura_CasaDoCodigo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura_CasaDoCodigo.Models
{
    public class Pedido : BaseModel
    {
        public Pedido()
        {
            Cadastro = new Cadastro();
        }
        public Pedido(Cadastro cadastro)
        {
            Cadastro = cadastro;
        }
        public List<ItemPedido> Itens { get; private set; } = new List<ItemPedido>();
        public int CadastroId { get; set; }
        public Cadastro Cadastro { get; private set; }

    }
}
