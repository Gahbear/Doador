using Doador.Domain.Commands;

namespace Doador.Domain.Interfaces
{
    public interface IProdutoService
    {
        Task<string> PostAsync(ProdutoCommand command);
    }
}
