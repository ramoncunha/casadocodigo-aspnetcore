using Alura_CasaDoCodigo.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Alura_CasaDoCodigo.Models
{
    [DataContract]
    public class ItemPedido : BaseModel
    {
        [DataMember]
        [Required]
        public Pedido Pedido { get; private set; }
        [DataMember]
        [Required]
        public Produto Produto { get; private set; }
        [DataMember]
        [Required]
        public int Quantidade { get; private set; }
        [DataMember]
        [Required]
        public decimal PrecoUnitario { get; private set; }
        [DataMember]
        public decimal Subtotal => Quantidade * PrecoUnitario;

        internal void AtualizaQuantidade(int quantidade)
        {
            Quantidade = quantidade;
        }

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
