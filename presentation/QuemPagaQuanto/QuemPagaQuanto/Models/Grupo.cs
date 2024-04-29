using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuemPagaQuanto.Models
{
    [Table("Grupos")]
    public class Grupo
    {
        [Key]

        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome do Grupo!")]
        [Display(Name = "Nome do Grupo")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Id do Usuário")]
        public int UsuarioId { get; set; }
        
        [ForeignKey("UsuarioId")]
        public  Usuario Usuario  { get; set; }


        

    }
}
