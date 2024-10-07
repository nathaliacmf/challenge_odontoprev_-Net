using Cadastro.Cliente.API.Domain.Entities;
using Cadastro.Cliente.API.Domain.Interfaces;
using Cadastro.Cliente.API.Infrastructure.Data.AppData;

namespace Cadastro.Cliente.API.Infrastructure.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {

        private readonly ApplicationContext _context;

        public ClienteRepository(ApplicationContext context)
        {
            _context = context;
        }

        public ClienteEntity? DeletarDados(int id)
        {
            try
            {
                var cliente = _context.Cliente.Find(id);

                if (cliente is not null)
                {
                    _context.Remove(cliente);
                    _context.SaveChanges();

                    return cliente;
                }

                //Gera um excecão para informar que nao foi possivel localizar o cliente
                throw new Exception("Não foi possivel localizar o cliente ");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public ClienteEntity? EditarDados(ClienteEntity entity)
        {
            try
            {
                var cliente = _context.Cliente.Find(entity.Id);

                if (cliente is not null)
                {
                    cliente.Idade = entity.Idade;
                    cliente.Email = entity.Email;
                    cliente.Nome = entity.Nome;

                    _context.Update(cliente);
                    _context.SaveChanges();

                    return cliente;
                }

                //Gera um excecão para informar que nao foi possivel localizar o cliente
                throw new Exception("Não foi possivel localizar o cliente ");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public ClienteEntity? ObterPorId(int id)
        {
            var cliente = _context.Cliente.Find(id);

            if (cliente is not null)
            {
                return cliente;
            }
            return null;
        }

        public IEnumerable<ClienteEntity>? ObterTodos()
        {
            var clientes = _context.Cliente.ToList();

            if (clientes.Any())
                return clientes;

            return null;
        }

        public ClienteEntity? SalvarDados(ClienteEntity entity)
        {
            try
            {
                _context.Add(entity);
                _context.SaveChanges();

                return entity;
            }
            catch (Exception)
            {
                throw new Exception("Não foi possivel salvar o cliente ");
            }

        }
    }
}
