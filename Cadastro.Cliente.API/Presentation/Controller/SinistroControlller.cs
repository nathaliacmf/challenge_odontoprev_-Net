using Cadastro.UsuarioSinistro.API.Application.Dtos;
using Cadastro.UsuarioSinistro.API.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro.UsuarioSinistro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SinistroController : ControllerBase
    {
        private readonly ISinistroApplicationService _sinistroService;

        public SinistroController(ISinistroApplicationService sinistroService)
        {
            _sinistroService = sinistroService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var sinistros = _sinistroService.ObterTodosSinistros();

            if (sinistros is null)
                return NoContent();

            return Ok(sinistros);
        }

        [HttpPost]
        public IActionResult Post([FromBody] SinistroDto sinistroDto)
        {
            var sinistro = _sinistroService.RegistrarSinistro(sinistroDto);
            return Ok(sinistro);
        }
    }
}
