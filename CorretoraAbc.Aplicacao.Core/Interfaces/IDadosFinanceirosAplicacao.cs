using CorretoraAbc.Aplicacao.Core.Aplicacao;
using CorretoraAbc.Domain.Core.Entities;
using System.Collections.Generic;

namespace CorretoraAbc.Aplicacao.Core.Interfaces
{
    public interface IDadosFinanceirosAplicacao
    {
        DadosEMAeMACDparaGrafico MonteDadosDeEMAeMACDParaListagem(List<Cotacao> cotacoes);
        string MonteDadosDeEMAeMACDParaGrafico(List<Cotacao> cotacoes);
    }
}
