namespace Departamentos.Application.Dtos
{
    /// <summary>
    /// Dados de transferência para um departamento.
    /// </summary>
    public class DepartamentoDto
    {
        /// <summary>
        /// Identificador único do departamento.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do departamento.
        /// </summary>
        public string Nome { get; set; } = string.Empty;

        /// <summary>
        /// Sigla do departamento.      
        /// </summary>
        public string Sigla { get; set; } = string.Empty;
    }
}
