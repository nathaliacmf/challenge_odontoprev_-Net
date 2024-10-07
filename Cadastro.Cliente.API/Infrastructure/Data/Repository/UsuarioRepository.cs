using Cadastro.UsuarioSinistro.API.Domain.Entities;
using Cadastro.UsuarioSinistro.API.Domain.Interfaces;
using Cadastro.UsuarioSinistro.API.Infrastructure.Data.AppData;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.UsuarioSinistro.API.Infrastructure.Data.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationContext _context;

        public UsuarioRepository(ApplicationContext context)
        {
            _context = context;
        }

        public UsuarioEntity? ObterPorEmailESenha(string email, string senha)
        {
            return _context.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        public UsuarioEntity? SalvarUsuario(UsuarioEntity entity)
        {
            _context.Usuarios.Add(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
