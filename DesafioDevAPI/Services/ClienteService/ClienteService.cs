using DesafioDevAPI.Data;
using DesafioDevAPI.Models;
using System.Collections.Generic;

namespace DesafioDevAPI.Services.ClienteService
{
    public class ClienteService : IClienteInterface
    {
        private readonly ApplicationDbContext _context;
        public ClienteService(ApplicationDbContext context)
        {
            _context = context;    
        }
        public Task<ServiceResponse<List<Cliente>>> CreateClientes(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<Cliente>>> DeleteClientes(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Cliente>> GetClienteById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<Cliente>>> GetClientes()
        {
            ServiceResponse < List < Cliente >> serviceResponse = new ServiceResponse<List<Cliente>> ();
            try
            {
                serviceResponse.Dados = _context.Cliente.ToList();
                if (serviceResponse.Dados.Count == 0)
                {
                    serviceResponse.Mensagem = "Nenhum dado encontrado!";
                }
            }
            catch (Exception ex) 
            { 
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Successo = false;
            }
            return serviceResponse;
        }

        public Task<ServiceResponse<List<Cliente>>> UpdateCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
