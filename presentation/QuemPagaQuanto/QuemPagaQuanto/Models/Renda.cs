using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuemPagaQuanto.Models
{
    [Table("Rendas")]
    public class Renda
    {
        [Key]
        public int Id { get; set; }
        public int MoradorId { get; set; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Obrigatório informar o valor da renda.")]
        public double Valor { get; set; }

        [Display(Name = "Renda é fixa?")]
        public bool RendaFixa { get; set; }

        [Display(Name = "Descrição")]
        public string? Descricao { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Data { get; set; }

        [ForeignKey("MoradorId")]
        public Morador Morador { get; set; }
    }
}
