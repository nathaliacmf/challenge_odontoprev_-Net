using Cadastro.UsuarioSinistro.API.Application.Dtos;
using Cadastro.UsuarioSinistro.API.Application.Interfaces;
using Cadastro.UsuarioSinistro.API.Domain.Entities;
using Cadastro.UsuarioSinistro.API.Domain.Interfaces;

namespace Cadastro.UsuarioSinistro.API.Application.Services
{
    public class UsuarioApplicationService : IUsuarioApplicationService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioApplicationService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public UsuarioEntity? AutenticarUsuario(string email, string senha)
        {
            return _usuarioRepository.ObterPorEmailESenha(email, senha);
        }

        public UsuarioEntity? RegistrarUsuario(UsuarioDto usuarioDto)
        {
            var usuario = new UsuarioEntity
            {
                Nome = usuarioDto.Nome,
                Email = usuarioDto.Email,
                Senha = usuarioDto.Senha
            };

            return _usuarioRepository.SalvarUsuario(usuario);
        }
    }
}
