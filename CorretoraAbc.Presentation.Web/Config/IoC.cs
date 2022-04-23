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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

            services.AddSingleton(typeof(IBase<>), typeof(BaseRepository<>));
            services.AddSingleton<IAcaoAplicacao, AcaoAplicacao>();
            services.AddSingleton<ICotacaoAplicacao, CotacaoAplicacao>();
            services.AddSingleton<IAcaoService, AcaoService>();
            services.AddSingleton<ICotacaoService, CotacaoService>();
            services.AddSingleton<IAcaoRepository, AcaoRepository>();
            services.AddSingleton<ICotacaoRepository, CotacaoRepository>();
            services.AddSingleton<ICalculadoraIndicadoresFinanceiros, CalculadoraIndicadoresFinanceiros>();
            services.AddSingleton<IDadosFinanceirosAplicacao, DadosFinanceirosAplicacao>();
        }
    }
}
