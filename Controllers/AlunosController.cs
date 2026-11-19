using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PrimeiroProjetoMVC.Models;

namespace PrimeiroProjetoMVC.Controllers
{
    public class AlunosController : Controller
    {
        private static List<Aluno> _alunos = new()
        {
            new Aluno {Id = 1, Nome = "Daniel Vorcaro", Email = "contato.daniel.vorcaro@gmail.com", Idade = 43},
            new Aluno {Id = 2, Nome = "Diogo Chelles", Email = "pi.diogo@gmail.com", Idade = 18}
        }; 

        // GET /Alunos - Listar todos os alunos
        public IActionResult Index()
        {
            return View(_alunos);
        }

        public IActionResult Detalhes(int id)
        {
            var aluno = _alunos.FirstOrDefault(a => a.Id == id);

            if (aluno == null)
            {
                return NotFound();
            }

            return View(aluno); 
        }
        
        // GET /Alunos/Criar - Exibir a view com todos os alunos
        [HttpGet] // - Data Notation
        public IActionResult Criar()
        {
            return View();
        }

        // POST Alunos/Criar - Receber dados da View por meio de um formulario de cadastro para adiocionar um novo aluno 
        [HttpPost]
        public IActionResult Criar(Aluno aluno)
        {
            if (!ModelState.IsValid) // Verifica se as validações feitas na model foram cumpridas
            {
                return View(aluno); // Retorna com erros de validação 
            }

            aluno.Id = _alunos.Any() ? _alunos.Max(a => a.Id) + 1 : 1;

            _alunos.Add(aluno);

            return RedirectToAction("Index");
        }

    }
}