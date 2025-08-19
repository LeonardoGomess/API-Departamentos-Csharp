using Departamentos.Application.Dtos;
using Departamentos.Application.UseCases.Funcionario;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Departamentos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FuncionarioController : ControllerBase
    {
        private readonly GetFuncionariosByDepartamentoUseCase _getByDeptUseCase;
        private readonly CreateFuncionarioUseCase _createUseCase;
        private readonly UpdateFuncionarioUseCase _updateUseCase;
        private readonly DeleteFuncionarioUseCase _deleteUseCase;

        public FuncionarioController(
            GetFuncionariosByDepartamentoUseCase getByDeptUseCase,
            CreateFuncionarioUseCase createUseCase,
            UpdateFuncionarioUseCase updateUseCase,
            DeleteFuncionarioUseCase deleteUseCase)
        {
            _getByDeptUseCase = getByDeptUseCase;
            _createUseCase = createUseCase;
            _updateUseCase = updateUseCase;
            _deleteUseCase = deleteUseCase;
        }

        [HttpGet("departamento/{departamentoId}")]
        public async Task<IActionResult> GetByDepartamento(int departamentoId)
            => Ok(await _getByDeptUseCase.ExecuteAsync(departamentoId));

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] FuncionarioDto dto)
        {
            await _createUseCase.ExecuteAsync(dto);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] FuncionarioDto dto)
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