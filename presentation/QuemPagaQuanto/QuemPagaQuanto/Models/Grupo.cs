using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuemPagaQuanto.Models
{
    [Table("Grupos")]
    public class Grupo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public int UsuarioId { get; set; }
        
        [ForeignKey("UsuarioId")]
        public  Usuario Usuario  { get; set; }
        

    }
}
