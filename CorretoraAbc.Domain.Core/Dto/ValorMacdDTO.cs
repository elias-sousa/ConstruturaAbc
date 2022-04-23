using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorretoraAbc.Domain.Core.Dto
{
    /// <summary>
    /// Tem como objetivo transportar dados de calulo modificados
    /// </summary>
    public class ValorMacdDTO
    {
        public DateTime Data { get; internal set; }
        public decimal Valor { get; internal set; }
        public decimal ValorSignal { get; internal set; }
        public decimal ValorHistorico { get; internal set; }
    }
}
