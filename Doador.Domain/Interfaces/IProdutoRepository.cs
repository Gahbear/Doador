using Doador.Domain.Commands;

namespace Doador.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        Task<string> PostAsync(ProdutoCommand command);
        void PostAsync();
    }
}
