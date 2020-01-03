using Microsoft.EntityFrameworkCore;
using mvc_alura;

namespace Alura_CasaDoCodigo
{
    public class DataService : IDataService
    {
        private readonly ApplicationContext contexto;

        public DataService(ApplicationContext context)
        {
            context = contexto;
        }

        public void InicializaDB()
        {
            contexto.Database.Migrate();
        }
    }
}
