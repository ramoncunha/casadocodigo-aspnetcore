using System.Runtime.Serialization;

namespace Alura_CasaDoCodigo.Repositories
{
    // Marcar atributos para serialização
    [DataContract]
    public abstract class BaseModel
    {
        [DataMember]
        public int Id { get; protected set; }

    }
}