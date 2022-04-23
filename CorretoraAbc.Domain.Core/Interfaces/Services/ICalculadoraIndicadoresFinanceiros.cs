using CorretoraAbc.Domain.Core.Dto;
using CorretoraAbc.Domain.Core.Entities;
using System.Collections.Generic;

namespace CorretoraAbc.Domain.Core.Interfaces.Services
{
    public interface ICalculadoraIndicadoresFinanceiros
    {
        IEnumerable<ValorEmaDTO> CalculeEma(IEnumerable<Cotacao> cotacoesx, int dias);
        IEnumerable<ValorMacdDTO> CalculeMacd(IEnumerable<Cotacao> cotacoes);
    }
}
