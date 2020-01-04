﻿using Alura_CasaDoCodigo.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alura_CasaDoCodigo.Models
{
    public class Cadastro : BaseModel
    {
        public Cadastro()
        {
        }
        public Pedido Pedido { get; set; }
        [Required]
        public string Nome { get; set; } = "";
        [Required]
        public string Email { get; set; } = "";
        [Required]
        public string Telefone { get; set; } = "";
        [Required]
        public string Endereco { get; set; } = "";
        [Required]
        public string Complemento { get; set; } = "";
        [Required]
        public string Bairro { get; set; } = "";
        [Required]
        public string Municipio { get; set; } = "";
        [Required]
        public string UF { get; set; } = "";
        [Required]
        public string CEP { get; set; } = "";
    }
}
