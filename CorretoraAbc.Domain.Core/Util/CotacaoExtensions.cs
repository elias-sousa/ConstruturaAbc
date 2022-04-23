using CorretoraAbc.Domain.Core.Entities;
using Skender.Stock.Indicators;
using System.Collections.Generic;
using System.Linq;

namespace CorretoraAbc.Domain.Core.Util
{
    public static class CotacaoExtensions
    {
        public static IEnumerable<Quote> ToQuotes(this IEnumerable<Cotacao> cotacaos)
        {
            return cotacaos.Select(c => new Quote { Date = c.Data, Open = c.Abertura, Close = c.Fechamento, Low = c.Baixa, High = c.Alta, Volume = c.Volume });
        }
    }
}
