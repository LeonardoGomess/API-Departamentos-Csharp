namespace Departamentos.Domain.Entities
{
    /// <summary>
    /// Representa um departamento da organização.
    /// </summary>
    public class Departamento
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

        /// <summary>
        /// Lista de funcionários associados ao departamento.
        /// </summary>
        public ICollection<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();
    }
}