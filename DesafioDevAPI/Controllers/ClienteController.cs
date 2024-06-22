using DesafioDevAPI.Models;
using DesafioDevAPI.Services.ClienteService;
using Microsoft.AspNetCore.Mvc;

namespace DesafioDevAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteInterface _clienteInterface;
        public ClienteController(IClienteInterface clienteInterface) {
            _clienteInterface = clienteInterface;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Cliente>>>> Get()
        {
            return Ok( await _clienteInterface.Get());
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Cliente>>>> Create(Cliente cliente)
        {
            return Ok(await _clienteInterface.Create(cliente));
        }


    }
}
