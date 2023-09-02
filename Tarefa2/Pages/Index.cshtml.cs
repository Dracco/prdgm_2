using Microsoft.AspNetCore.Mvc.RazorPages;
using Tarefa2.Models;
using Tarefa2.Repositorios;

namespace Tarefa2.Pages
{
    public class IndexModel : PageModel
    {
        public List<Colaborador> colaboradores { get; private set; }
        private readonly ILogger<IndexModel> _logger;
        readonly IColaboradorRepository _colaboradorRepository;
        readonly IDepartamentoRepository _departamentoRepository;

        public IndexModel(ILogger<IndexModel> logger, IColaboradorRepository colaboradorRepository, IDepartamentoRepository departamentoRepository)
        {
            _logger = logger;
            _colaboradorRepository = colaboradorRepository;
            _departamentoRepository = departamentoRepository;
            //Seed();

        }

        private void Seed()
        {
            //_departamentoRepository.Clear();

            //var departamento = new Departamento();
            //departamento.Id = 1;
            //departamento.Nome = "TI";
            //_departamentoRepository.AddDepartamento(departamento);


            //_colaboradorRepository.Clear();
            //var colaborador = new Colaborador();
            //colaborador.Id = 1;
            //colaborador.Nome = "Joe";
            //colaborador.Salario = 70000;
            //colaborador.DeptId = departamento.Id;
            //colaborador.NomeDepartamento = departamento.Nome;
            //_colaboradorRepository.AddColaborador(colaborador);

            //colaborador = new Colaborador();
            //colaborador.Id = 4;
            //colaborador.Nome = "Max";
            //colaborador.Salario = 90000;
            //colaborador.DeptId = departamento.Id;
            //colaborador.NomeDepartamento = departamento.Nome;
            //_colaboradorRepository.AddColaborador(colaborador);



            //departamento = new Departamento();
            //departamento.Id = 2;
            //departamento.Nome = "Vendas";
            //_departamentoRepository.AddDepartamento(departamento);

            //colaborador = new Colaborador();
            //colaborador.Id = 2;
            //colaborador.Nome = "Henry";
            //colaborador.Salario = 80000;
            //colaborador.DeptId = departamento.Id;
            //colaborador.NomeDepartamento = departamento.Nome;
            //_colaboradorRepository.AddColaborador(colaborador);

            //colaborador = new Colaborador();
            //colaborador.Id = 3;
            //colaborador.Nome = "Sam";
            //colaborador.Salario = 60000;
            //colaborador.DeptId = departamento.Id;
            //colaborador.NomeDepartamento = departamento.Nome;
            //_colaboradorRepository.AddColaborador(colaborador);
        }

        public void OnGet()
        {
            //colaboradores = _colaboradorRepository.GetColaboradores();
            colaboradores = _colaboradorRepository.RelatorioSalarioPorDepartamento();

        }
    }
}