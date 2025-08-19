namespace Departamentos.Application.Dtos
{
    /// <summary>
    /// Dados de transfer�ncia para um funcion�rio.
    /// </summary>
    public class FuncionarioDto
    {
        /// <summary>
        /// Identificador �nico do funcion�rio.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome completo do funcion�rio.
        /// </summary>
        public string Nome { get; set; } = string.Empty;

        /// <summary>
        /// URL ou caminho da foto do funcion�rio.
        /// </summary>
        public string Foto { get; set; } = string.Empty;

        /// <summary>
        /// Registro Geral (RG) do funcion�rio.
        /// </summary>
        public string RG { get; set; } = string.Empty;

        /// <summary>
        /// Identificador do departamento ao qual o funcion�rio pertence.
        /// </summary>
        public int DepartamentoId { get; set; }
    }
}