using CorretoraAbc.Domain.Core.Entities;
using CorretoraAbc.Domain.Core.Interfaces.Repository;
using CorretoraAbc.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace CorretoraAbc.Domain.Core.Services
{
    public class AcaoService : IAcaoService
    {
        private readonly IAcaoRepository _acaoRepository;

        public AcaoService(IAcaoRepository acaoRepository)
        {
            _acaoRepository = acaoRepository;
        }

        public Acao Add(Acao obj)
        {
           return  _acaoRepository.Add(obj);
        }

        public Acao Delete(Acao obj)
        {
            return _acaoRepository.Delete(obj);
        }

        public Acao FindById(Guid id)
        {
            return _acaoRepository.FindById(id);
        }

        public IReadOnlyList<Acao> ListAll()
        {
            return _acaoRepository.ListAll();
        }

        public Acao Update(Acao obj)
        {
            return _acaoRepository.Update(obj);
        }
    }
}
