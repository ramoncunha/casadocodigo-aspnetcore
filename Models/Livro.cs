using Alura_CasaDoCodigo.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Alura_CasaDoCodigo.Models
{
    public class Livro : BaseModel
    {
        [Required]
        public string Codigo { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public decimal Preco { get; set; }

    }
}
