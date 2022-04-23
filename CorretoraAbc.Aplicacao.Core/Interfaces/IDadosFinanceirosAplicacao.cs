using CorretoraAbc.Aplicacao.Core.Aplicacao;
using CorretoraAbc.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorretoraAbc.Aplicacao.Core.Interfaces
{
    public interface IDadosFinanceirosAplicacao
    {
        DadosEMAeMACDparaGrafico MonteDadosDeEMAeMACDParaListagem(List<Cotacao> cotacoes);
        string MonteDadosDeEMAeMACDParaGrafico(List<Cotacao> cotacoes);
    }
}
