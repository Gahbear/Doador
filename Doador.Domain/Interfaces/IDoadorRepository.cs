using Doador.Domain.Commands;

namespace Doador.Domain.Interfaces
{
    public interface IDoadorRepository
    {

        Task<IEnumerable<DoadorCommand>> GetDoadoresAsync();
    }
}
