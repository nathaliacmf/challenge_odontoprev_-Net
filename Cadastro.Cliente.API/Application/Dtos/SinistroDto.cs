using System;
using System.ComponentModel.DataAnnotations;

namespace Cadastro.UsuarioSinistro.API.Application.Dtos
{
    public class SinistroDto
    {
        [Required(ErrorMessage = "Campo {nameof(Descricao)} é obrigatorio")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "Descrição deve ter no mínimo 10 caracteres")]
        public string Descricao { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo {nameof(Valor)} é obrigatorio")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor do sinistro deve ser positivo.")]
        public decimal Valor { get; set; }

        public DateTime DataOcorrencia { get; set; } = DateTime.Now;
    }
}
