using Microsoft.EntityFrameworkCore;
using QuemPagaQuanto.Database;
using QuemPagaQuanto.Models;

namespace QuemPagaQuanto.Services
{
    public class CalculoDespesas
    {
        public double CalculoPerCapta { get; set; }
        public List<ProporcionalMorador> ProporcionalMoradores { get; set; }
        public double NegativoProporcional { get; set; }
        public int NumeroMoradores { get; set; }
        public List<Despesa> Despesas { get; set; }
    }

    public class ProporcionalMorador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public double Renda { get; set; }
    }

    public class CalcularDespesasService
    {
        private readonly AppDbContext db;

        public CalcularDespesasService(AppDbContext dbContext)
        {
            this.db = dbContext;
        }

        public CalculoDespesas CalcularProporcional(int grupoId, int? mes, int? ano)

        {
            var grupo = db.Grupos.Find(grupoId);
            if (grupo == null) return null;

            var despesas = db.Despesas
                .Where(e => e.GrupoId == grupoId && (mes == null || e.Data.Month == mes) &&
                            (ano == null || e.Data.Year == ano))
                .OrderBy(e => e.Data)
                .ToList();

            var moradores = db.Moradores
                .Include(m => m.Rendas)
                .Where(m => m.GrupoId == grupoId).ToList();

            double despesasTotalGrupo = 0;

            foreach (var despesa in despesas)
            {
                despesasTotalGrupo += despesa.Valor;
            }

            double calculoPerCapta = despesasTotalGrupo / moradores.Count;

            List<ProporcionalMorador> listaProprocionalMorador = new List<ProporcionalMorador>();

            double rendaTotalGrupo = 0;
            foreach (var morador in moradores)
            {
                rendaTotalGrupo += morador.RendaTotal(mes, ano);
            }

            foreach (var morador in moradores)
            {
                var renda = morador.RendaTotal(mes, ano);

                double valor = 0;

                if (renda > 0)
                {
                    valor = renda / rendaTotalGrupo * despesasTotalGrupo;
                }

                if (valor > renda)
                {
                    valor = renda;
                }
                
                listaProprocionalMorador.Add(new ProporcionalMorador()
                {
                    Id = morador.Id,
                    Nome = morador.Nome,
                    Valor = valor,
                    Renda = renda
                });
            }

            return new CalculoDespesas()
            {
                CalculoPerCapta = calculoPerCapta,
                ProporcionalMoradores = listaProprocionalMorador.OrderByDescending(i => i.Valor).ToList(),
                NegativoProporcional = despesasTotalGrupo - rendaTotalGrupo,
                NumeroMoradores = moradores.Count,
                Despesas = despesas
            };
        }
    }
}