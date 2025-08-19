using Departamentos.Application.Dtos;
using Departamentos.Domain.Entities;
using Departamentos.Domain.Interfaces;
using System.Threading.Tasks;

namespace Departamentos.Application.UseCases.Departamento
{
    public class UpdateDepartamentoUseCase
    {
        private readonly IDepartamentoRepository _repository;
        public UpdateDepartamentoUseCase(IDepartamentoRepository repository)
        {
            _repository = repository;
        }
        public async Task ExecuteAsync(DepartamentoDto dto)
        {
            var departamento = await _repository.GetByIdAsync(dto.Id);
            if (departamento != null)
            {
                departamento.Nome = dto.Nome;
                departamento.Sigla = dto.Sigla;
                await _repository.UpdateAsync(departamento);
            }
        }
    }
}