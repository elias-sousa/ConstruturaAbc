using CorretoraAbc.Aplicacao.Core.Interfaces;
using CorretoraAbc.Domain.Core.Entities;
using CorretoraAbc.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorretoraAbc.Aplicacao.Core.Aplicacao
{
   public class AcaoAplicacao : IAcaoAplicacao
    {
        private readonly IAcaoService _acaoService;

        public AcaoAplicacao(IAcaoService acaoService)
        {
            _acaoService = acaoService;
        }

        public Acao Add(Acao obj)
        {
           return _acaoService.Add(obj);
        }

        public Acao Update(Acao obj)
        {
           return _acaoService.Update(obj);
        }

        public Acao Delete(Acao obj)
        {
           return _acaoService.Delete(obj);
        }

        public IReadOnlyList<Acao> ListAll()
        {
            return _acaoService.ListAll();
        }

        public Acao FindById(Guid id)
        {
            return _acaoService.FindById(id);
        }
    }
}
