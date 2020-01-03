using Alura_CasaDoCodigo.Models;
using System.Collections.Generic;

namespace Alura_CasaDoCodigo.Repositories
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<Livro> livros);
    }
}