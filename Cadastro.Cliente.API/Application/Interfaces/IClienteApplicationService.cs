using Cadastro.Cliente.API.Application.Dtos;
using Cadastro.Cliente.API.Domain.Entities;

namespace Cadastro.Cliente.API.Application.Interfaces
{
    public interface IClienteApplicationService
    {
        IEnumerable<ClienteEntity>? ObterTodosClientes();
        ClienteEntity? ObterClientePorId(int id);
        ClienteEntity? SalvarDadosCliente(ClienteDto entity);
        ClienteEntity? EditarDadosCliente(int id, ClienteDto entity);
        ClienteEntity? DeletarDadosCliente(int id);
    }
}
