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
        public async Task<ServiceResponse<List<Cliente>>> Create(Cliente cliente)
        {
            ServiceResponse<List<Cliente>> serviceResponse = new ServiceResponse<List<Cliente>>();
            try
            {
                if (cliente == null) {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Informe os dados para o cadastro!";
                    serviceResponse.Successo = false;
                    
                    return serviceResponse;
                }

                _context.Add(cliente);
                await _context.SaveChangesAsync();
                serviceResponse.Dados = _context.Cliente.ToList();

            }
            catch (Exception ex) {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Successo = false;
            }

            return serviceResponse;
        }

        public Task<ServiceResponse<List<Cliente>>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Cliente>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<Cliente>>> Get()
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

        public Task<ServiceResponse<List<Cliente>>> Update(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
