using DesafioDevAPI.Models;

namespace DesafioDevAPI.Services.ClienteService
{
    public interface IClienteInterface
    {
        Task<ServiceResponse<List<Cliente>>> GetClientes();
        Task<ServiceResponse<List<Cliente>>> CreateClientes(Cliente cliente);
        Task<ServiceResponse<Cliente>> GetClienteById(int id);
        Task<ServiceResponse<List<Cliente>>> UpdateCliente(Cliente cliente);
        Task<ServiceResponse<List<Cliente>>> DeleteClientes(int id);


    }
}
