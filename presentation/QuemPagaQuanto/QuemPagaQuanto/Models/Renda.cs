using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuemPagaQuanto.Models
{
    [Table("Rendas")]
    public class Renda
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o valor da renda")]
        public double Valor { get; set; }

        [Display(Name = "Renda fixa")]
        public bool RendaFixa { get; set; }

        [Required(ErrorMessage = "Obrigatório informar descrição da renda")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data da renda")]
        public DateTime Data { get; set; }

    }
}
