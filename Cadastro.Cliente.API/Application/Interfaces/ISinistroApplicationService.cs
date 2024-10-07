using Cadastro.UsuarioSinistro.API.Application.Dtos;
using Cadastro.UsuarioSinistro.API.Domain.Entities;
using System.Collections.Generic;

namespace Cadastro.UsuarioSinistro.API.Application.Interfaces
{
    public interface ISinistroApplicationService
    {
        IEnumerable<SinistroEntity>? ObterTodosSinistros();
        SinistroEntity? RegistrarSinistro(SinistroDto sinistroDto);
        SinistroEntity? ObterSinistroPorId(int id);
    }
}
