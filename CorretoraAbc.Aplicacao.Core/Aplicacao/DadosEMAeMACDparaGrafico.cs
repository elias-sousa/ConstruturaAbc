using CorretoraAbc.Domain.Core.Dto;
using CorretoraAbc.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorretoraAbc.Aplicacao.Core.Aplicacao
{
    public class DadosEMAeMACDparaGrafico
    {
        public IEnumerable<Cotacao> Cotacoes { get; set; }
        public IEnumerable<ValorEmaDTO> ValoresEma9 { get; set; }
        public IEnumerable<ValorEmaDTO> ValoresEma12 { get; set; }
        public IEnumerable<ValorEmaDTO> ValoresEma26 { get; set; }
        public IEnumerable<ValorMacdDTO> ValoresMacd { get; set; }
        public int MenorQuantidade
        {
            get
            {
                var menorIndice = Cotacoes.Count();
                if (ValoresEma9.Count() < menorIndice)
                {
                    menorIndice = ValoresEma9.Count();
                }
                if (ValoresEma12.Count() < menorIndice)
                {
                    menorIndice = ValoresEma12.Count();
                }
                if (ValoresEma26.Count() < menorIndice)
                {
                    menorIndice = ValoresEma26.Count();
                }
                if (ValoresMacd.Count() < menorIndice)
                {
                    menorIndice = ValoresMacd.Count();
                }

                return menorIndice;
            }
        }
        public DadosEMAeMACDparaGrafico(IEnumerable<Cotacao> cotacoes,
                                        IEnumerable<ValorEmaDTO> valoresEma9,
                                        IEnumerable<ValorEmaDTO> valoresEma12,
                                        IEnumerable<ValorEmaDTO> valoresEma26,
                                        IEnumerable<ValorMacdDTO> valoresMacd)
        {
            Cotacoes = cotacoes;
            ValoresEma9 = valoresEma9;
            ValoresEma12 = valoresEma12;
            ValoresEma26 = valoresEma26;
            ValoresMacd = valoresMacd;
        }
    }
}
