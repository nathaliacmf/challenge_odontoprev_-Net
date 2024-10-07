using Cadastro.UsuarioSinistro.API.Domain.Entities;
using System.Collections.Generic;

namespace Cadastro.UsuarioSinistro.API.Domain.Interfaces
{
    public interface ISinistroRepository
    {
        IEnumerable<SinistroEntity>? ObterTodos();
        SinistroEntity? ObterPorId(int id);
        SinistroEntity? SalvarSinistro(SinistroEntity entity);
    }
}
