using QuemPagaQuanto.Services;

namespace QuemPagaQuanto.Models;
public class RelatorioData
{
    public List<Despesa> Despesas { get; set; }
    public CalculoDespesas Calculo { get; set; }
}