using Doador.Domain.Commands;

namespace Doador.Domain.Interfaces
{
    public interface IDoadorService
    {

        Task<string> PostAsync(DoadorCommand command);
    }
}
