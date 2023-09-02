using Tarefa2.Models;

namespace Tarefa2.Repositorios
{
    public class DepartamentoRepository : IDepartamentoRepository
    {
        public List<Departamento> GetDepartamentos()
        {
            using (var context = new ApiContext())
            {
                var list = context.Departamentos
                    .ToList();
                return list;
            }
        }

        public void AddDepartamento(Departamento departamento)
        {
            using (var context = new ApiContext())
            {
                context.Departamentos.Add(departamento);
                context.SaveChanges();
            }
        }
        public void Clear()
        {
            using (var context = new ApiContext())
            {
                context.Departamentos.RemoveRange(GetDepartamentos());
                context.SaveChanges();
            }
        }
    }
}
