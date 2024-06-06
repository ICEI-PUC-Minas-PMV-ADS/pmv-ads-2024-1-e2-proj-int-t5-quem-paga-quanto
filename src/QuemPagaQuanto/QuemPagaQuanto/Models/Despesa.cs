using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuemPagaQuanto.Models
{
    [Table("Despesas")]
    public class Despesa
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Insira a data da despesa.")]
        public DateTime Data { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Vencimento { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "Insira o valor da despesa.")]
        public double Valor { get; set; }

        public string? Descricao { get; set; }

        [Required]
        [Display(Name = "Grupo")]
        public int GrupoId { get; set; }

        [ForeignKey("GrupoId")]
        public Grupo Grupo { get; set; }
    }
}

