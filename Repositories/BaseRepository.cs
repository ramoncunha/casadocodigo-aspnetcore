
namespace Alura_CasaDoCodigo.Repositories
{
    public class BaseRepository<T> where T : BaseModel //--Se todos os modelos derivassem de BaseModel esse parâmetro 
                                                       // faria com que a classe que fosse substituida em T, também derivasse de BaseModel
    {
        protected readonly ApplicationContext contexto;
        protected readonly Microsoft.EntityFrameworkCore.DbSet<T> dbSet;

        public BaseRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<T>();
        }
    }
}
