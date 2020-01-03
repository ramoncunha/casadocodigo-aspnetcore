﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_alura.Models
{
    public class Pedido
    {
        public Pedido()
        {
            Cadastro = new Cadastro();
            Cadastro.Id = IdCadastro;
        }
        public Pedido(Cadastro cadastro)
        {
            Cadastro = cadastro;
        }
        public int Id { get; set; }
        public List<ItemPedido> Itens { get; private set; } = new List<ItemPedido>();
        public int IdCadastro { get; set; }
        public Cadastro Cadastro { get; private set; }

    }
}