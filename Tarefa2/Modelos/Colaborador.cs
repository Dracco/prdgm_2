using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tarefa2.Models
{
    public class Colaborador
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Salario { get; set; }
        public int DeptId { get; set; }
        public string NomeDepartamento { get; set; }
    }
}
