using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuemPagaQuanto.Models 
{
    [Table("Moradores")]
    public class Morador
    {
        [Key]
        public int Id  { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public int Email { get; set; }
        
        [Required]
        public int GrupoId  { get; set; }
        
        [ForeignKey("GrupoId")]
        public Grupo Grupo { get; set; }
    }
}
