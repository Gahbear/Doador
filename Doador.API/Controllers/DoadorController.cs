using Doador.Domain.Commands;
using Doador.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Doador.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoadorController : ControllerBase
    {
        private readonly IDoadorService _doadorService;

        public DoadorController(IDoadorService doadorService)
        {
            _doadorService = doadorService;   
        }
        [HttpPost]
        [Route("CadastrarDoador")]
        public async Task<IActionResult> PostAsync([FromBody] DoadorCommand command)
        {
            return Ok(await _doadorService.PostAsync(command));
        }
    }
}
