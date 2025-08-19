namespace Departamentos.Application.Dtos
{
    /// <summary>
    /// Dados de transferência para um funcionário.
    /// </summary>
    public class FuncionarioDto
    {
        /// <summary>
        /// Identificador único do funcionário.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome completo do funcionário.
        /// </summary>
        public string Nome { get; set; } = string.Empty;

        /// <summary>
        /// URL ou caminho da foto do funcionário.
        /// </summary>
        public string Foto { get; set; } = string.Empty;

        /// <summary>
        /// Registro Geral (RG) do funcionário.
        /// </summary>
        public string RG { get; set; } = string.Empty;

        /// <summary>
        /// Identificador do departamento ao qual o funcionário pertence.
        /// </summary>
        public int DepartamentoId { get; set; }
    }
}