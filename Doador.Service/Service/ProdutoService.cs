using Doador.Domain.Commands;
using Doador.Domain.Interfaces;

namespace Doador.Service.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoService(IProdutoRepository repository)
        {
            _produtoRepository = repository;
        }
        public Task<string> PostAsync(ProdutoCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
