using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cadastro.UsuarioSinistro.API.Domain.Entities
{
    [Table("tb_sinistro")]
    public class SinistroEntity
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public decimal Valor { get; set; }
        public DateTime DataOcorrencia { get; set; }
    }
}
