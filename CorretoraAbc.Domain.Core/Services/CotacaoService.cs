using CorretoraAbc.Domain.Core.Entities;
using CorretoraAbc.Domain.Core.Interfaces.Repository;
using CorretoraAbc.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace CorretoraAbc.Domain.Core.Services
{
    public class CotacaoService : ICotacaoService
    {
        private readonly ICotacaoRepository _cotacaoRepository;

        public CotacaoService(ICotacaoRepository cotacaoRepository)
        {
            _cotacaoRepository = cotacaoRepository;
        }

        public Cotacao Add(Cotacao obj)
        {
            return _cotacaoRepository.Add(obj);
        }

        public Cotacao Delete(Cotacao obj)
        {
            return _cotacaoRepository.Delete(obj);
        }

        public Cotacao FindById(Guid id)
        {
            return _cotacaoRepository.FindById(id);
        }

        public IReadOnlyList<Cotacao> ListAll()
        {
            return _cotacaoRepository.ListAll();
        }

        public Cotacao Update(Cotacao obj)
        {
            return _cotacaoRepository.Update(obj);
        }
    }
}
