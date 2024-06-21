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
        public async Task<ActionResult<ServiceResponse<List<Cliente>>>> GetClientes()
        {
            return Ok( await _clienteInterface.GetClientes());
        }
    }
}
