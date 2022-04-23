using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorretoraAbc.Domain.Core.Dto
{
    /// <summary>
    /// Tem omo razão transportar dados de calulos da EMA
    /// </summary>
    public class ValorEmaDTO
    {
        public DateTime Data { get; internal set; }
        public decimal Valor { get; internal set; }
    }
}
