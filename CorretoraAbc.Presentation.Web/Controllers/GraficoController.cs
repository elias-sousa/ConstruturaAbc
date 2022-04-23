using CorretoraAbc.Aplicacao.Core.Interfaces;
using CorretoraAbc.Presentation.Web.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CorretoraAbc.Presentation.Web.Controllers
{
    public class GraficoController : Controller
    {
        private readonly IWebHostEnvironment _appEnvironment;
        private readonly IAcaoAplicacao _acaoApp;
        private readonly IDadosFinanceirosAplicacao _dadosFinanceirosService;

        public GraficoController(IAcaoAplicacao acaoApp, IDadosFinanceirosAplicacao dadosFinanceirosService, IWebHostEnvironment appEnvironment)
        {
            _acaoApp = acaoApp;
            _dadosFinanceirosService = dadosFinanceirosService;
            _appEnvironment = appEnvironment;
        }

        public IActionResult Index()
        {
            var acao = _acaoApp.ListAll()?.FirstOrDefault();
            var cotacoes = acao?.Cotacoes.OrderBy(cotacao => cotacao.Data).ToList();
            var viewModel = CrieViewModel(cotacoes);
            viewModel.Acao = acao.Sigla;
            return View(viewModel);
        }

        private GraficoViewModel CrieViewModel(List<Domain.Core.Entities.Cotacao>? cotacoes)
        {
            string nomeArquivo = "dados.json";
            var viewModel = new GraficoViewModel
            {
                JsonData = _dadosFinanceirosService.MonteDadosDeEMAeMACDParaGrafico(cotacoes),
                FilePath = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}/Files/{nomeArquivo}"
            };

            CrieArquivo(viewModel.JsonData, nomeArquivo);

            return viewModel;
        }

        private void CrieArquivo(string dados, string nomeArquivo)
        {
            string pasta = "Files";
            string caminho_WebRoot = _appEnvironment.WebRootPath;
            string caminhoPastaFile = caminho_WebRoot + "\\" + pasta;

            if (!Directory.Exists(caminhoPastaFile))
            {
                Directory.CreateDirectory(caminhoPastaFile);
            }

            var filePath = Path.Combine(caminhoPastaFile, nomeArquivo);

            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }

            using FileStream fs = System.IO.File.Create(filePath);
            byte[] bytes = new UTF8Encoding(true).GetBytes(dados);
            fs.Write(bytes, 0, bytes.Length);
        }
    }
}
