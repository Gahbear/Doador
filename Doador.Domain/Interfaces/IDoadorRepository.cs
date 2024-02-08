using Doador.Domain.Commands;

namespace Doador.Domain.Interfaces
{
    public interface IDoadorRepository
    {

        Task<string> PostAsync(DoadorCommand command);
    }
}
