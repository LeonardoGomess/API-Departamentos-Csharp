using Departamentos.Domain.Interfaces;

namespace Departamentos.Domain.Services
{
    public class DepartamentoService
    {
        private readonly IDepartamentoRepository _repository;
        public DepartamentoService(IDepartamentoRepository repository)
        {
            _repository = repository;
        }
        // M�todos de servi�o ser�o implementados conforme os UseCases
    }
}