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
        // M�todos de servi�o ser�o implementados conforme os UseCases
    }
}