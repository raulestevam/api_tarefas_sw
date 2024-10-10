using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace api_tarefas.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int id_usuario { get; set; }

        [Display (Name = "Nome do usuário")]
        [Required]
        public string nome_usuario { get; set;}

        [Display(Name = "Email do usuário")]
        [Required]
        public string email_usuario { get; set; }

        [Display(Name = "Senha do usuário")]
        [Required]
        public string senha_usuario { get; set; }

        //navigation resource (relations existence)
        public ICollection <Tarefa> tarefas { get; set; }
    }
}
