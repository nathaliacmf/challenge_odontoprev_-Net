using Cadastro.UsuarioSinistro.API.Application.Dtos;
using Cadastro.UsuarioSinistro.API.Application.Interfaces;
using Cadastro.UsuarioSinistro.API.Domain.Entities;
using Cadastro.UsuarioSinistro.API.Domain.Interfaces;
using System.Collections.Generic;

namespace Cadastro.UsuarioSinistro.API.Application.Services
{
    public class SinistroApplicationService : ISinistroApplicationService
    {
        private readonly ISinistroRepository _sinistroRepository;

        public SinistroApplicationService(ISinistroRepository sinistroRepository)
        {
            _sinistroRepository = sinistroRepository;
        }

        public IEnumerable<SinistroEntity>? ObterTodosSinistros()
        {
            return _sinistroRepository.ObterTodos();
        }

        public SinistroEntity? RegistrarSinistro(SinistroDto sinistroDto)
        {
            var sinistro = new SinistroEntity
            {
                Descricao = sinistroDto.Descricao,
                Valor = sinistroDto.Valor,
                DataOcorrencia = sinistroDto.DataOcorrencia
            };

            return _sinistroRepository.SalvarSinistro(sinistro);
        }

        public SinistroEntity? ObterSinistroPorId(int id)
        {
            return _sinistroRepository.ObterPorId(id);
        }
    }
}
