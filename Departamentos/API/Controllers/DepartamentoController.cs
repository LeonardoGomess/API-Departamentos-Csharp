using Departamentos.Application.Dtos;
using Departamentos.Application.UseCases.Departamento;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Departamentos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartamentoController : ControllerBase
    {
        private readonly GetDepartamentosUseCase _getUseCase;
        private readonly CreateDepartamentoUseCase _createUseCase;
        private readonly UpdateDepartamentoUseCase _updateUseCase;
        private readonly DeleteDepartamentoUseCase _deleteUseCase;

        public DepartamentoController(
            GetDepartamentosUseCase getUseCase,
            CreateDepartamentoUseCase createUseCase,
            UpdateDepartamentoUseCase updateUseCase,
            DeleteDepartamentoUseCase deleteUseCase)
        {
            _getUseCase = getUseCase;
            _createUseCase = createUseCase;
            _updateUseCase = updateUseCase;
            _deleteUseCase = deleteUseCase;
        }

        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _getUseCase.ExecuteAsync());

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DepartamentoDto dto)
        {
            await _createUseCase.ExecuteAsync(dto);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] DepartamentoDto dto)
        {
            await _updateUseCase.ExecuteAsync(dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _deleteUseCase.ExecuteAsync(id);
            return Ok();
        }
    }
}