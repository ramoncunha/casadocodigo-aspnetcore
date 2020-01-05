using Alura_CasaDoCodigo.Repositories;
using Newtonsoft.Json;
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
        [JsonProperty("Codigo")]
        public string Codigo { get; set; }
        [Required]
        [JsonProperty("Nome")]
        public string Nome { get; set; }
        [Required]
        [JsonProperty("Preco")]
        public decimal Preco { get; set; }

    }
}
