using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_tarefas.Models
{
    [Table("Tarefas")]
    public class Tarefa
    {
        [Key]

        public int id_tarefa { get; set; }

        [Display(Name = "Nome da tarefa")]
        [Required]
        public string nome_tarefa { get; set; }

        [Display(Name = "Descrição da tarefa")]
        [Required]
        public string descricao_tarefa { get; set; }

        [Display(Name = "Data prevista da tarefa")]
        [Required]
        public DateTime data_prevista { get; set; }

        [Display(Name = "Data de conclusão da tarefa")]
        [Required]
        public DateTime data_conclusao { get; set; }

        [ForeignKey("fk_usuario")]
        [Display (Name = "Id do usuário")]
        [Required]
        public int fk_usuario { get; set; }
        
        //validate the relation between 1 task with 1 user
        public Usuario usuario { get; set; }
    }
}
