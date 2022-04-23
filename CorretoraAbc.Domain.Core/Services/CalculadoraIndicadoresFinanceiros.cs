using CorretoraAbc.Domain.Core.Dto;
using CorretoraAbc.Domain.Core.Entities;
using CorretoraAbc.Domain.Core.Interfaces.Services;
using CorretoraAbc.Domain.Core.Util;
using Skender.Stock.Indicators;
using System.Collections.Generic;
using System.Linq;

namespace CorretoraAbc.Domain.Core.Services
{
    public class CalculadoraIndicadoresFinanceiros : ICalculadoraIndicadoresFinanceiros
    {
        public IEnumerable<ValorMacdDTO> CalculeMacd(IEnumerable<Cotacao> cotacoes)
        {
            var quotes = cotacoes.ToQuotes();

            var result = quotes.GetMacd();

            var valoresMacd = result.Select(r => new ValorMacdDTO
            {
                Data = r.Date,
                Valor = r.Macd.GetValueOrDefault(),
                ValorSignal = r.Signal.GetValueOrDefault(),
                ValorHistorico = r.Histogram.GetValueOrDefault()
            });

            return valoresMacd;
        }

        public IEnumerable<ValorEmaDTO> CalculeEma(IEnumerable<Cotacao> cotacoes, int dias)
        {
            var quotes = cotacoes.ToQuotes();

            var result = quotes.GetEma(dias);

            var valoresEma = result.Select(r => new ValorEmaDTO
            {
                Data = r.Date,
                Valor = r.Ema.GetValueOrDefault()
            });

            return valoresEma;
        }
    }
}
