using Cadastro.UsuarioSinistro.API.Application.Dtos;
using Cadastro.UsuarioSinistro.API.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro.UsuarioSinistro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioApplicationService _usuarioService;

        public UsuarioController(IUsuarioApplicationService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] UsuarioDto dto)
        {
            var usuario = _usuarioService.AutenticarUsuario(dto.Email, dto.Senha);

            if (usuario is null)
                return Unauthorized("Usuário ou senha inválidos.");

            return Ok(usuario);
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] UsuarioDto usuarioDto)
        {
            var usuario = _usuarioService.RegistrarUsuario(usuarioDto);
            return Ok(usuario);
        }
    }
}
