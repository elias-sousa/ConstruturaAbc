using System;
using System.ComponentModel.DataAnnotations;

namespace CorretoraAbc.Domain.Core.Entities
{
    public class Cotacao
    {
        [Key]
        public Guid IdCotacao { get; set; }
        public Guid AcaoId { get; set; }
        public DateTime Data { get; set; }
        public decimal Abertura { get; set; }
        public decimal Alta { get; set; }
        public decimal Baixa { get; set; }
        public decimal Fechamento { get; set; }      
        public decimal FechamentoAjustado { get; set; }
        public int Volume { get; set; }  
        public Acao Acao { get; set; }

    }
}
