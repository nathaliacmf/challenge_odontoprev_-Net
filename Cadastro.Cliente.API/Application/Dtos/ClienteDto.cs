using System.ComponentModel.DataAnnotations;

namespace Cadastro.Cliente.API.Application.Dtos
{
    public class ClienteDto
    {
        [Required(ErrorMessage = $"Campo {nameof(Nome)} é obrigatorio")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "Campo deve ter no minimo 5 caracteres")]
        public string Nome { get; set; } = string.Empty;
        
        [Required(ErrorMessage = $"Campo {nameof(Idade)} é obrigatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "O valor da idade deve ser um número inteiro positivo.")]
        public int Idade { get; set; }

        [Required(ErrorMessage = $"Campo {nameof(Email)} é obrigatorio")]
        [EmailAddress(ErrorMessage = "O Email não é valido")]
        public string Email { get; set; } = string.Empty;
    }
}
