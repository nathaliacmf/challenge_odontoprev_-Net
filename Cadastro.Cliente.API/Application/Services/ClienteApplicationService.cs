using Cadastro.Cliente.API.Application.Dtos;
using Cadastro.Cliente.API.Application.Interfaces;
using Cadastro.Cliente.API.Domain.Entities;
using Cadastro.Cliente.API.Domain.Interfaces;

namespace Cadastro.Cliente.API.Application.Services
{
    public class ClienteApplicationService : IClienteApplicationService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteApplicationService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;   
        }

        public ClienteEntity? DeletarDadosCliente(int id)
        {
            return _clienteRepository.DeletarDados(id);
        }

        public ClienteEntity? EditarDadosCliente(int id, ClienteDto entity)
        {
            var Cliente = new ClienteEntity { 
                Id = id,    
                Nome = entity.Nome,
                Email = entity.Email,
                Idade = entity.Idade,
            };

            return _clienteRepository.EditarDados(Cliente);
        }

        public ClienteEntity? ObterClientePorId(int id)
        {
            return _clienteRepository.ObterPorId(id);
        }

        public IEnumerable<ClienteEntity>? ObterTodosClientes()
        {
            return _clienteRepository.ObterTodos();
        }

        public ClienteEntity? SalvarDadosCliente(ClienteDto entity)
        {
            var Cliente = new ClienteEntity
            {
                Nome = entity.Nome,
                Email = entity.Email,
                Idade = entity.Idade,
            };

            return _clienteRepository.SalvarDados(Cliente);
        }
    }
}
