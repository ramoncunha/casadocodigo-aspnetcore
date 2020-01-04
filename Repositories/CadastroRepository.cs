using Alura_CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura_CasaDoCodigo.Repositories
{
    public class CadastroRepository : BaseRepository<Cadastro>
    {
        public CadastroRepository(ApplicationContext contexto) : base(contexto)
        {
        }
    }
}
