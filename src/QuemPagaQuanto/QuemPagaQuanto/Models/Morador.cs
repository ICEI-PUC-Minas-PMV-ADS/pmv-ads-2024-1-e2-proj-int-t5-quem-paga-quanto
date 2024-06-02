using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuemPagaQuanto.Models
{
    [Table("Moradores")]
    public class Morador
    {
        [Key] public int Id { get; set; }

        [Required] public string Nome { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required] public int GrupoId { get; set; }

        [ForeignKey("GrupoId")] public Grupo Grupo { get; set; }

        public List<Renda> Rendas { get; set; }

        public double RendaTotal(int? mes, int? ano)
        {
            double rendaTotal = 0;

            foreach (var renda in Rendas)
            {
                var data = renda.Data;

                if (data != null)
                {
                    var dataFormatada = data.GetValueOrDefault();

                    if (renda.RendaFixa && mes >= dataFormatada.Month && ano >= dataFormatada.Year)
                        rendaTotal += renda.Valor;
                    else if (mes == dataFormatada.Month && ano == dataFormatada.Year)
                        rendaTotal += renda.Valor;
                }
            }

            return rendaTotal;
        }
    }
}