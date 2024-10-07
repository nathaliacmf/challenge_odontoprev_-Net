using System.ComponentModel.DataAnnotations;

namespace Cadastro.UsuarioSinistro.API.Application.Dtos
{
    public class UsuarioDto
    {
        [Required(ErrorMessage = $"Campo {nameof(Nome)} � obrigatorio")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "Campo deve ter no minimo 5 caracteres")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = $"Campo {nameof(Email)} � obrigatorio")]
        [EmailAddress(ErrorMessage = "O Email n�o � valido")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = $"Campo {nameof(Senha)} � obrigatorio")]
        public string Senha { get; set; } = string.Empty;
    }
}
