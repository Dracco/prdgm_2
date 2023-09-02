using Tarefa2.Models;

namespace Tarefa2.Repositorios
{
    public interface IDepartamentoRepository
    {
        public List<Departamento> GetDepartamentos();
        public void AddDepartamento(Departamento departamento);
        public void Clear();
    }

}
