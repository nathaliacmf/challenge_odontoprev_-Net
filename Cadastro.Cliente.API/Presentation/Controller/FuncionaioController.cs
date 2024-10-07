using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro.Cliente.API.Presentation.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionaioController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Ola Funcionario");
        }
    }
}
