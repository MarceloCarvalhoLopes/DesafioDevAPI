using DesafioDevAPI.Data;
using DesafioDevAPI.Dto;
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

        public async Task<ServiceResponse<List<ClienteModel>>> Get()
        {
            ServiceResponse<List<ClienteModel>> serviceResponse = new ServiceResponse<List<ClienteModel>>();
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
        public async Task<ServiceResponse<ClienteModel>> GetById(int id)
        {
            ServiceResponse<ClienteModel> serviceResponse = new ServiceResponse<ClienteModel>();
            try
            {
                ClienteModel cliente = _context.Cliente.FirstOrDefault(x => x.Id == id);

                if (cliente == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "´Cliente não localizado";
                    serviceResponse.Successo = false;
                }

                serviceResponse.Dados = cliente;
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Successo = false;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<ClienteModel>>> GetByUF(string uf)
        {
            ServiceResponse<List<ClienteModel>> serviceResponse = new ServiceResponse<List<ClienteModel>>();
            try
            {


                ClienteModel cliente = _context.Cliente.FirstOrDefault(x => x.Uf == uf);


                if (cliente == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "´Nenhum registro localizado";
                    serviceResponse.Successo = false;
                }
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Successo = false;
            }
            return serviceResponse;

        }
        public async Task<ServiceResponse<List<ClienteModel>>> Create(ClienteDto clienteDto)
        {
            ServiceResponse<List<ClienteModel>> serviceResponse = new ServiceResponse<List<ClienteModel>>();
            try
            {
                var cliente = new ClienteModel()
                {
                    Nome = clienteDto.Nome,
                    Cpf = clienteDto.Cpf,
                    DataNascimento = clienteDto.DataNascimento,
                    Uf = clienteDto.Uf
                };

                _context.Add(cliente);
                await _context.SaveChangesAsync();
                serviceResponse.Dados = await _context.Cliente.ToListAsync();
                serviceResponse.Mensagem = "Cliente criado com sucesso!";

                return serviceResponse;

            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Successo = false;
                return serviceResponse;
            }

        }

        public async Task<ServiceResponse<List<ClienteModel>>> Delete(int id)
        {
            ServiceResponse<List<ClienteModel>> serviceResponse = new ServiceResponse<List<ClienteModel>>();
            try
            {
                ClienteModel cliente = _context.Cliente.FirstOrDefault(x => x.Id == id);

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

        public async Task<ServiceResponse<List<ClienteModel>>> Update(ClienteModel clienteModel)
        {
            ServiceResponse<List<ClienteModel>> serviceResponse = new ServiceResponse<List<ClienteModel>>();

            try
            {
                ClienteModel cliente = _context.Cliente.AsNoTracking().FirstOrDefault(x => x.Id == x.Id);

                if (cliente == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Cliente não localiado!";
                    serviceResponse.Successo = false;
                }
                _context.Cliente.Update(clienteModel);
                await _context.SaveChangesAsync();

                serviceResponse.Dados = _context.Cliente.ToList();
            }
            catch (Exception ex)
            {

                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Successo = false;
            }

            return serviceResponse;
        }



    }
}
