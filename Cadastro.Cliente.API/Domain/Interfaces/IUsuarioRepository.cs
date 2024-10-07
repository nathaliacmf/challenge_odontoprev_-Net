using Cadastro.UsuarioSinistro.API.Domain.Entities;

namespace Cadastro.UsuarioSinistro.API.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        UsuarioEntity? ObterPorEmailESenha(string email, string senha);
        UsuarioEntity? SalvarUsuario(UsuarioEntity entity);
    }
}
