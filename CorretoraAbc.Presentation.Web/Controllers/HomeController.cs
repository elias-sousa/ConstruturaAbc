using CorretoraAbc.Aplicacao.Core.Aplicacao;
using CorretoraAbc.Aplicacao.Core.Interfaces;
using CorretoraAbc.Presentation.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CorretoraAbc.Presentation.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAcaoAplicacao _acaoApp;
        private readonly IDadosFinanceirosAplicacao _dadosFinanceirosService;

        public HomeController(IAcaoAplicacao acaoApp, IDadosFinanceirosAplicacao dadosFinanceirosService)
        {
            _acaoApp = acaoApp;
            _dadosFinanceirosService = dadosFinanceirosService;
        }

        public IActionResult Index()
        {
            var viewModel = MonteViewModel();
            return View(viewModel);
        }

        private IEnumerable<HomeViewModel> MonteViewModel()
        {
            var acao = _acaoApp.ListAll()?.FirstOrDefault();
            var cotacoes = acao?.Cotacoes.OrderBy(cotacao => cotacao.Data).ToList();
            var dadosParaOGrafico = _dadosFinanceirosService.MonteDadosDeEMAeMACDParaListagem(cotacoes);
            return MapeieParaViewModel(dadosParaOGrafico);
        }

        private IEnumerable<HomeViewModel> MapeieParaViewModel(DadosEMAeMACDparaGrafico dadosParaOGrafico)
        {
            var viewModels = new List<HomeViewModel>();

            for (int i = 0; i < dadosParaOGrafico.MenorQuantidade; i++)
            {
                viewModels.Add(
                    new HomeViewModel
                    {
                        Data = dadosParaOGrafico.Cotacoes.ElementAt(i).Data,
                        FechamentoDoDia = dadosParaOGrafico.Cotacoes.ElementAt(i).Fechamento,
                        Ema9 = dadosParaOGrafico.ValoresEma9.ElementAt(i).Valor,
                        Ema12 = dadosParaOGrafico.ValoresEma12.ElementAt(i).Valor,
                        Ema26 = dadosParaOGrafico.ValoresEma26.ElementAt(i).Valor,
                        Macd = dadosParaOGrafico.ValoresMacd.ElementAt(i).Valor,
                        MacdSignal = dadosParaOGrafico.ValoresMacd.ElementAt(i).ValorSignal,
                        MacdHistograma = dadosParaOGrafico.ValoresMacd.ElementAt(i).ValorHistorico
                    }
                );
            }

            return viewModels.OrderByDescending(vm => vm.Data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
