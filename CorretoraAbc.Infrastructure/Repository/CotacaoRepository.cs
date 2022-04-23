using CorretoraAbc.Domain.Core.Entities;
using CorretoraAbc.Domain.Core.Interfaces.Repository;
using CorretoraAbc.Infrastructure.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorretoraAbc.Infrastructure.Repository
{
    public class CotacaoRepository : BaseRepository<Cotacao>, ICotacaoRepository
    {
        private readonly DbContextOptions<ConstrutoraContext> _optionsBuilder;
        private string GetConnectString { get; }
        public CotacaoRepository(DbContextOptions<ConstrutoraContext> optionsBilder) : base(optionsBilder)
        {
            _optionsBuilder = optionsBilder;
        }
    }
}
