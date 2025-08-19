using Departamentos.Domain.Interfaces;

namespace Departamentos.Domain.Services
{
    public class FuncionarioService
    {
        private readonly IFuncionarioRepository _repository;
        public FuncionarioService(IFuncionarioRepository repository)
        {
            _repository = repository;
        }
        // Métodos de serviço serão implementados conforme os UseCases
    }
}