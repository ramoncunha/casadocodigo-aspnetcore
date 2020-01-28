using Alura_CasaDoCodigo.Models;

namespace Alura_CasaDoCodigo
{
    public interface ICadastroRepository
    {
        Cadastro Update(int cadastroId, Cadastro novoCadastro);
    }
}