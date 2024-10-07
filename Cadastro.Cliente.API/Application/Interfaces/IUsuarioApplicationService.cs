using Cadastro.UsuarioSinistro.API.Application.Dtos;
using Cadastro.UsuarioSinistro.API.Domain.Entities;

namespace Cadastro.UsuarioSinistro.API.Application.Interfaces
{
    public interface IUsuarioApplicationService
    {
        UsuarioEntity? AutenticarUsuario(string email, string senha);
        UsuarioEntity? RegistrarUsuario(UsuarioDto usuarioDto);
    }
}
