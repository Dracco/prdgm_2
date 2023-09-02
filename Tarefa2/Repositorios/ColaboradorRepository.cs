using Tarefa2.Models;

namespace Tarefa2.Repositorios
{
    public class ColaboradorRepository : IColaboradorRepository
    {
        
        string stringConexao = string.Format(@"Server=(localdb)\mssqllocaldb; Integrated Security=true; AttachDbFileName={0};", System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "paradigmadb.mdf"));


        public List<Colaborador> RelatorioSalarioPorDepartamento()
        {
            Colaborador colaborador = new Colaborador();
            List<Colaborador> colaboradores = new List<Colaborador>();
            using (var conn = new System.Data.SqlClient.SqlConnection(stringConexao))
            {
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    using (var comm = new System.Data.SqlClient.SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = @"select Departamento.nome as nomed, Colaborador.nome as nomec, relatorio.salario 
                        from (
                        select DeptId, max(salario) as salario
                        from colaborador
                        group by DeptId) as relatorio
                        join Departamento on relatorio.DeptId = Departamento.id
                        join Colaborador on relatorio.salario = Colaborador.Salario";
                        using (var reader = comm.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                colaborador = new Colaborador();
                                colaborador.NomeDepartamento = Convert.ToString(reader["nomed"]);
                                colaborador.Nome = Convert.ToString(reader["nomec"]);
                                colaborador.Salario = Convert.ToInt32(reader["salario"]);

                                colaboradores.Add(colaborador);
                            }
                        }
                    }
                }
            }
            return colaboradores;

            //    /* select Departamento.nome, Colaborador.nome, relatorio.salario 
            //        from (
            //        select DeptId, max(salario) as salario
            //        from colaborador
            //        group by DeptId) as relatorio
            //        join Departamento on relatorio.DeptId = Departamento.id
            //        join Colaborador on relatorio.salario = Colaborador.Salario
            //     */
            //}
        }
    }
}
