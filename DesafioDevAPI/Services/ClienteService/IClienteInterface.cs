using DesafioDevAPI.Models;

namespace DesafioDevAPI.Services.ClienteService
{
    public interface IClienteInterface
    {
        Task<ServiceResponse<List<Cliente>>> Get();
        Task<ServiceResponse<List<Cliente>>> Create(Cliente cliente);
        Task<ServiceResponse<Cliente>> GetById(int id);
        Task<ServiceResponse<List<Cliente>>> Update(Cliente cliente);
        Task<ServiceResponse<List<Cliente>>> Delete(int id);


    }
}
