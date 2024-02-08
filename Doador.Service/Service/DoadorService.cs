using Doador.Domain.Commands;
using Doador.Domain.Interfaces;

namespace Doador.Service.Service
{
    public class DoadorService : IDoadorService
    {
        private readonly IDoadorRepository _doadorRepository;
        public DoadorService(IDoadorRepository repository)
        {
            _doadorRepository = repository;
        }
        public Task<string> PostAsync(DoadorCommand command)
        {
           return _doadorRepository.PostAsync(command);
        }
    }
}
