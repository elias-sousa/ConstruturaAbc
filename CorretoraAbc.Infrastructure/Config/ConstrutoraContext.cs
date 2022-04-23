using CorretoraAbc.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CorretoraAbc.Infrastructure.Config
{
    public class ConstrutoraContext : DbContext
    {
        /*
            comando para criar uma fotografia do banco de dados

            Add-Migration Inicial -verbose

         Atualiza o banco de dados
          Update-Database -verbose
       */

        public DbSet<Acao> Acoes { get; set; }
        public DbSet<Cotacao> Cotacoes { get; set; }

        public ConstrutoraContext()
        {

        }

        public ConstrutoraContext(DbContextOptions<ConstrutoraContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            LoadingData.LoadInitialData(modelBuilder);
        }

        private string GetConnectionString()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Elias\source\repos\CorretoraAbc\CorretoraAbc.Infrastructure\Bd\DbCorretoraAbc.mdf;Integrated Security=True";
        }
    }
}
