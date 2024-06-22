using DesafioDevAPI.Models;

namespace DesafioDevAPI.Services.ClienteService
{
    public interface IClienteInterface
    {
        Task<ServiceResponse<List<ClienteModel>>> Get();
        Task<ServiceResponse<List<ClienteModel>>> Create(ClienteModel clienteModel);
        Task<ServiceResponse<ClienteModel>> GetById(int id);
        Task<ServiceResponse<List<ClienteModel>>> GetByUF(string uf);
        Task<ServiceResponse<List<ClienteModel>>> Update(ClienteModel clienteModel);
        Task<ServiceResponse<List<ClienteModel>>> Delete(int id);


    }
}
