using Departamentos.Domain.Interfaces;
using System.Threading.Tasks;

namespace Departamentos.Application.UseCases.Departamento
{
    public class DeleteDepartamentoUseCase
    {
        private readonly IDepartamentoRepository _repository;
        public DeleteDepartamentoUseCase(IDepartamentoRepository repository)
        {
            _repository = repository;
        }
        public async Task ExecuteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}