using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorretoraAbc.Domain.Core.Entities
{
    public class Acao
    {
        public Guid Id { get; set; }

        [MaxLength(300)]
        public string Nome { get; set; }

        [MaxLength(10)]
        public string Sigla { get; set; }

        public IEnumerable<Cotacao> Cotacoes { get; set; }


    }
}
