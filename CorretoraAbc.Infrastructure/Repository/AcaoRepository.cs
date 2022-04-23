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
   public class AcaoRepository : BaseRepository<Acao>, IAcaoRepository
    {
        private readonly DbContextOptions<ConstrutoraContext> _optionsBuilder;
        private string GetConnectString { get; }
        public AcaoRepository(DbContextOptions<ConstrutoraContext> optionsBilder) : base(optionsBilder)
        {
            _optionsBuilder = optionsBilder;
        }

        public override IReadOnlyList<Acao> ListAll()
        {
            using var db = new ConstrutoraContext(_optionsBuilder);
            return db.Acoes
                     .Include(a => a.Cotacoes)
                     .AsNoTracking()
                     .ToList();
        }

        public override Acao FindById(Guid id)
        {
            using var db = new ConstrutoraContext(_optionsBuilder);
            return db.Acoes
                     .Include(a => a.Cotacoes)
                     .FirstOrDefault(a => a.Id == id);
        }
    }
}
