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
        // Métodos de serviço serão implementados conforme os UseCases
    }
}