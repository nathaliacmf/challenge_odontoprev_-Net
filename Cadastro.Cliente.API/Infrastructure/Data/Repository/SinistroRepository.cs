using Cadastro.UsuarioSinistro.API.Domain.Entities;
using Cadastro.UsuarioSinistro.API.Domain.Interfaces;
using Cadastro.UsuarioSinistro.API.Infrastructure.Data.AppData;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Cadastro.UsuarioSinistro.API.Infrastructure.Data.Repository
{
    public class SinistroRepository : ISinistroRepository
    {
        private readonly ApplicationContext _context;

        public SinistroRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<SinistroEntity>? ObterTodos()
        {
            return _context.Sinistros.ToList();
        }

        public SinistroEntity? ObterPorId(int id)
        {
            return _context.Sinistros.Find(id);
        }

        public SinistroEntity? SalvarSinistro(SinistroEntity entity)
        {
            _context.Sinistros.Add(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
