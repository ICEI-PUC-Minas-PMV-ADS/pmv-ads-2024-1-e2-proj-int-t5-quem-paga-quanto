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
        public string Email { get; set; }
        
        [Required]
        public int GrupoId  { get; set; }
        
        [ForeignKey("GrupoId")]
        public Grupo Grupo { get; set; }

        public List<Renda> Rendas { get; set; }

        public double RendaTotal()
        {
            double rendaTotal = 0;
            
            foreach (var renda in Rendas)
            {
                rendaTotal += renda.Valor;
            }

            return rendaTotal;
        } 
    }
}
