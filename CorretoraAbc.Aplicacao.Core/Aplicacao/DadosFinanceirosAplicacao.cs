using CorretoraAbc.Aplicacao.Core.Interfaces;
using CorretoraAbc.Domain.Core.Entities;
using CorretoraAbc.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace CorretoraAbc.Aplicacao.Core.Aplicacao
{
    public class DadosFinanceirosAplicacao : IDadosFinanceirosAplicacao
    {
        private readonly ICalculadoraIndicadoresFinanceiros _calculadoraIndicadoresFinanceiros;

        public DadosFinanceirosAplicacao(ICalculadoraIndicadoresFinanceiros calculadoraIndicadoresFinanceiros)
        {
            _calculadoraIndicadoresFinanceiros = calculadoraIndicadoresFinanceiros;
        }

        public DadosEMAeMACDparaGrafico MonteDadosDeEMAeMACDParaListagem(List<Cotacao> cotacoes)
        {
            var valoresEma9 = _calculadoraIndicadoresFinanceiros.CalculeEma(cotacoes, 10);
            var valoresEma12 = _calculadoraIndicadoresFinanceiros.CalculeEma(cotacoes, 15);
            var valoresEma26 = _calculadoraIndicadoresFinanceiros.CalculeEma(cotacoes, 30);
            var valoresMacd = _calculadoraIndicadoresFinanceiros.CalculeMacd(cotacoes);

            return new DadosEMAeMACDparaGrafico(cotacoes, valoresEma9, valoresEma12, valoresEma26, valoresMacd);
        }

        public string MonteDadosDeEMAeMACDParaGrafico(List<Cotacao> cotacoes)
        {
            var dados = new List<List<double>>();
            for (int i = 0; i < cotacoes.Count; i++)
            {
                var dado = new List<double>();
                dado.Add(cotacoes.ElementAt(i).Data.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds);
                dado.Add((double)cotacoes.ElementAt(i).Abertura);
                dado.Add((double)cotacoes.ElementAt(i).Alta);
                dado.Add((double)cotacoes.ElementAt(i).Baixa);
                dado.Add((double)cotacoes.ElementAt(i).Fechamento);
                dados.Add(dado);
            }
            return JsonSerializer.Serialize(dados);
        }
    }
}
