using DesafioDevAPI.Dto;
using DesafioDevAPI.Models;
using DesafioDevAPI.Services.ClienteService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DesafioDevAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteInterface _clienteInterface;
        public ClienteController(IClienteInterface clienteInterface) {
            _clienteInterface = clienteInterface;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<ClienteModel>>>> Get()
        {
            return Ok(await _clienteInterface.Get());
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<ServiceResponse<List<ClienteModel>>>> Create(ClienteDto clienteDto)
        {
            return Ok(await _clienteInterface.Create(clienteDto));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<ClienteModel>>> GetById(int id)
        {
            ServiceResponse<ClienteModel> serviceResponse = await _clienteInterface.GetById(id);
            return Ok(serviceResponse);
        }
        [HttpGet("clientes/{uf}")]
        public async Task<ActionResult<List<ClienteModel>>> getByUF(string uf)
        {
            ServiceResponse<List<ClienteModel>> serviceResponse = await _clienteInterface.GetByUF(uf);
            return Ok(serviceResponse);
        }

        [HttpPut]
        public async Task<ActionResult<List<ClienteModel>>> Update(ClienteModel cliente)
        {
            ServiceResponse<List<ClienteModel>> serviceResponse = await _clienteInterface.Update(cliente);
            return Ok(serviceResponse);            
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<ClienteModel>>>> Delete(int id)
        {
            ServiceResponse<List<ClienteModel>> serviceResponse = await _clienteInterface.Delete(id);
            return Ok(serviceResponse);

        }



    }
}
