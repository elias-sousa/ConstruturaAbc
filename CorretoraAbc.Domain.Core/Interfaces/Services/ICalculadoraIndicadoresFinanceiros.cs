using CorretoraAbc.Domain.Core.Dto;
using CorretoraAbc.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorretoraAbc.Domain.Core.Interfaces.Services
{
    public interface ICalculadoraIndicadoresFinanceiros
    {
        IEnumerable<ValorEmaDTO> CalculeEma(IEnumerable<Cotacao> cotacoesx, int dias);
        IEnumerable<ValorMacdDTO> CalculeMacd(IEnumerable<Cotacao> cotacoes);
    }
}
