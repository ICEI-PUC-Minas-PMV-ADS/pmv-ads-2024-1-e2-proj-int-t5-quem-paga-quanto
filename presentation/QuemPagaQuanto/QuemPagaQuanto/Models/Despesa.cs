using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuemPagaQuanto.Models
{
    [Table("Despesas")]
    public class Despesa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Insira a Data da Despesa")]
        public DateTime Data { get; set; }

        public DateTime Vencimento { get; set; }

        [Required(ErrorMessage = "Insira o Valor da Despesa")]
        public double Valor { get; set; }

        [Required(ErrorMessage = "Insira uma Descrição da Despesa")]
        public string Descricao { get; set; }

        [Required]
        [Display(Name = "Id do Grupo")]
        public int GrupoId { get; set; }

        [ForeignKey("GrupoId")]
        public Grupo Grupo { get; set; }
    }
}

