using Departamentos.Domain.Interfaces;
using System.Threading.Tasks;

namespace Departamentos.Application.UseCases.Funcionario
{
    public class DeleteFuncionarioUseCase
    {
        private readonly IFuncionarioRepository _repository;
        public DeleteFuncionarioUseCase(IFuncionarioRepository repository)
        {
            _repository = repository;
        }
        public async Task ExecuteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}