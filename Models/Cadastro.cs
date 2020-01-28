using Alura_CasaDoCodigo.Repositories;
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
        [MaxLength(50, ErrorMessage = "Nome deve conter no máximo 50 caracteres.")]
        [MinLength(5, ErrorMessage ="Nome deve conter no mínimo 5 caracteres.")]
        [Required(ErrorMessage ="Nome é obrigatório.")]
        public string Nome { get; set; } = "";
        [Required(ErrorMessage = "Email é obrigatório.")]
        public string Email { get; set; } = "";
        [Required(ErrorMessage = "Telefone é obrigatório.")]
        public string Telefone { get; set; } = "";
        [Required(ErrorMessage = "Endereco é obrigatório.")]
        public string Endereco { get; set; } = "";
        [Required(ErrorMessage = "Complemento é obrigatório.")]
        public string Complemento { get; set; } = "";
        [Required(ErrorMessage = "Bairro é obrigatório.")]
        public string Bairro { get; set; } = "";
        [Required(ErrorMessage = "Municipio é obrigatório.")]
        public string Municipio { get; set; } = "";
        [Required(ErrorMessage = "UF é obrigatório.")]
        public string UF { get; set; } = "";
        [Required(ErrorMessage = "CEP é obrigatório.")]
        public string CEP { get; set; } = "";

        internal void Update(Cadastro novoCadastro)
        {
            this.Nome = novoCadastro.Nome;
            this.Email = novoCadastro.Email;
            this.Telefone = novoCadastro.Telefone;
            this.Endereco = novoCadastro.Endereco;
            this.Complemento = novoCadastro.Complemento;
            this.Bairro = novoCadastro.Bairro;
            this.Municipio = novoCadastro.Municipio;
            this.UF = novoCadastro.UF;
            this.CEP = novoCadastro.CEP;
        }
    }
}
