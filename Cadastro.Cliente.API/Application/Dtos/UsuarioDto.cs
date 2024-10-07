using System.ComponentModel.DataAnnotations;

namespace Cadastro.UsuarioSinistro.API.Application.Dtos
{
    public class UsuarioDto
    {
        [Required(ErrorMessage = $"Campo {nameof(Nome)} é obrigatorio")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "Campo deve ter no minimo 5 caracteres")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = $"Campo {nameof(Email)} é obrigatorio")]
        [EmailAddress(ErrorMessage = "O Email não é valido")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = $"Campo {nameof(Senha)} é obrigatorio")]
        public string Senha { get; set; } = string.Empty;
    }
}
