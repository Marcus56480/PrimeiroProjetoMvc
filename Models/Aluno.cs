using System.ComponentModel.DataAnnotations;

namespace PrimeiroProjetoMVC.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Nome deve conter entre 2 e 50 Caracteres")]
        public string Nome { get; set; } = "";
        [Required(ErrorMessage = "O E-mail é obrigatorio")]
        [EmailAddress(ErrorMessage = "E-mail Inválido")]
        public string Email { get; set; } = string.Empty;
        [Range(16, 100, ErrorMessage = "Idade deve ser entre 16 e 100")]
        public int Idade { get; set; }
    }
}