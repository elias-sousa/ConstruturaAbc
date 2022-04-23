using CorretoraAbc.Domain.Core.Entities;
using CorretoraAbc.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using CorretoraAbc.Aplicacao.Core.Interfaces;

namespace CorretoraAbc.Aplicacao.Core.Aplicacao
{
    public class CotacaoAplicacao : ICotacaoAplicacao
    {
        private readonly ICotacaoService _cotacaoService;

        public CotacaoAplicacao(ICotacaoService cotacaoService)
        {
            _cotacaoService = cotacaoService;
        }

        public Cotacao Add(Cotacao obj)
        {
            return _cotacaoService.Add(obj);
        }

        public Cotacao Update(Cotacao obj)
        {
            return _cotacaoService.Update(obj);
        }

        public Cotacao Delete(Cotacao obj)
        {
            return _cotacaoService.Delete(obj);
        }

        public IReadOnlyList<Cotacao> ListAll()
        {
            return _cotacaoService.ListAll();
        }

        public Cotacao FindById(Guid id)
        {
            return _cotacaoService.FindById(id);
        }
    }
}
