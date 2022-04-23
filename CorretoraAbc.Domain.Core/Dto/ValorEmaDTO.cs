using System;

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
