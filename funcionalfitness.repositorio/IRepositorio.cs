
using funcionalfitness.shared.DTOS;

namespace funcionalfitness.repositorio
{
    public interface IRepositorio<E> where E : class, IEntityBase
    {
        Task Post(E entity);
        Task Post(RegistroUsuarioDTO registroUsuario);
    }
}