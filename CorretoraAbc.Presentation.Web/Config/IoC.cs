using CorretoraAbc.Aplicacao.Core.Aplicacao;
using CorretoraAbc.Aplicacao.Core.Interfaces;
using CorretoraAbc.Domain.Core.Interfaces;
using CorretoraAbc.Domain.Core.Interfaces.Repository;
using CorretoraAbc.Domain.Core.Interfaces.Services;
using CorretoraAbc.Domain.Core.Services;
using CorretoraAbc.Infrastructure.Config;
using CorretoraAbc.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CorretoraAbc.Presentation.Web.Config
{
    public static class IoC
    {
        public static void Configurar(this IServiceCollection services, IConfiguration configuration)
        {
            var connection = configuration.GetConnectionString("MapaEstacao");

            services.AddDbContext<ConstrutoraContext>(options =>
            {
                options.UseSqlServer(connection);
            });

            services.AddTransient(typeof(IBase<>), typeof(BaseRepository<>));
            services.AddTransient<IAcaoAplicacao, AcaoAplicacao>();
            services.AddTransient<ICotacaoAplicacao, CotacaoAplicacao>();
            services.AddTransient<IAcaoService, AcaoService>();
            services.AddTransient<ICotacaoService, CotacaoService>();
            services.AddTransient<IAcaoRepository, AcaoRepository>();
            services.AddTransient<ICotacaoRepository, CotacaoRepository>();
            services.AddTransient<ICalculadoraIndicadoresFinanceiros, CalculadoraIndicadoresFinanceiros>();
            services.AddTransient<IDadosFinanceirosAplicacao, DadosFinanceirosAplicacao>();
        }
    }
}
