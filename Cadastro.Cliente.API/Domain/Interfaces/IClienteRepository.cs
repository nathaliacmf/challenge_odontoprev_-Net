using Cadastro.Cliente.API.Domain.Entities;

namespace Cadastro.Cliente.API.Domain.Interfaces
{
    public interface IClienteRepository
    {
        IEnumerable<ClienteEntity>? ObterTodos();
        ClienteEntity? ObterPorId(int id);
        ClienteEntity? SalvarDados(ClienteEntity entity);
        ClienteEntity? EditarDados(ClienteEntity entity);
        ClienteEntity? DeletarDados(int id);

    }
}
