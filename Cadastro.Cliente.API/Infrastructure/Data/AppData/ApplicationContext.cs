using Cadastro.Cliente.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.Cliente.API.Infrastructure.Data.AppData
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<UsuarioEntity> Usuarios { get; set; }
        public DbSet<SinistroEntity> Sinistros { get; set; }
        public DbSet<ClienteEntity> Cliente { get; set; }
    }
}
