using CorretoraAbc.Domain.Core.Entities;
using CorretoraAbc.Domain.Core.Interfaces.Repository;
using CorretoraAbc.Infrastructure.Config;
using Microsoft.EntityFrameworkCore;

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
