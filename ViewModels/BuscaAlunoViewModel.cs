using PrimeiroProjetoMVC.Models;

namespace PrimeiroProjetoMVC.ViewModels
{
    public class BuscaAlunoViewModel
    {
        public string? TermoBusca { get; set; }
        public List<Aluno> Resultados { get; set; } = new();
    }
}