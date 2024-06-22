using DesafioDevAPI.Data;
using DesafioDevAPI.Models;
using Microsoft.EntityFrameworkCore;

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

        public async Task<ServiceResponse<List<Cliente>>> Delete(int id)
        {
            ServiceResponse<List<Cliente>> serviceResponse = new ServiceResponse<List<Cliente>>();
            try
            {
                Cliente cliente = _context.Cliente.FirstOrDefault(x => x.Id == id);

                if (cliente == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Cliente não encontrado!";
                    serviceResponse.Successo = false;

                    return serviceResponse;
                }

                _context.Cliente.Remove(cliente);
                await _context.SaveChangesAsync();

                serviceResponse.Dados = _context.Cliente.ToList();
            }
            catch (Exception ex) {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Successo = false;
            }
            return serviceResponse;

        }

        public async Task<ServiceResponse<List<Cliente>>> Get()
        {
            ServiceResponse<List<Cliente>> serviceResponse = new ServiceResponse<List<Cliente>>();
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
        public async Task<ServiceResponse<Cliente>> GetById(int id)
        {
            ServiceResponse<Cliente> serviceResponse = new ServiceResponse<Cliente>();
            try
            {
                Cliente cliente = _context.Cliente.FirstOrDefault(x => x.Id == id);
                
                if (cliente == null) {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "´Cliente não localizado";
                    serviceResponse.Successo = false;
                }
                
                serviceResponse.Dados = cliente;
            }
            catch (Exception ex) {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Successo = false;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Cliente>>> GetByUF(string uf)
        {
            ServiceResponse<List<Cliente>> serviceResponse = new ServiceResponse<List<Cliente>>();
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

        public async Task<ServiceResponse<List<Cliente>>> Update(Cliente cliente)
        {
            ServiceResponse<List<Cliente>> serviceResponse = new ServiceResponse<List<Cliente>>();

            try
            {
                Cliente cliente1 = _context.Cliente.AsNoTracking().FirstOrDefault(x => x.Id == x.Id);

                if (cliente1 == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Cliente não localiado!";
                    serviceResponse.Successo = false;
                }
                _context.Cliente.Update(cliente);
                await _context.SaveChangesAsync();

                serviceResponse.Dados = _context.Cliente.ToList();
            }
            catch (Exception ex) {

                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Successo = false;
            }

            return serviceResponse;
        }

    
    }
}
