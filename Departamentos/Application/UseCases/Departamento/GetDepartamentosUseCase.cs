using Departamentos.Application.Dtos;
using Departamentos.Domain.Entities;
using Departamentos.Domain.Interfaces;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace Departamentos.Application.UseCases.Departamento
{
    public class GetDepartamentosUseCase
    {
        private readonly IDepartamentoRepository _repository;
        public GetDepartamentosUseCase(IDepartamentoRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<DepartamentoDto>> ExecuteAsync()
        {
            var departamentos = await _repository.GetAllAsync();
            return departamentos.Select(d => new DepartamentoDto
            {
                Id = d.Id,
                Nome = d.Nome,
                Sigla = d.Sigla
            });
        }
    }
}