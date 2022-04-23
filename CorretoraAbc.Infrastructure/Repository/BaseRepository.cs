using CorretoraAbc.Domain.Core.Interfaces;
using CorretoraAbc.Infrastructure.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorretoraAbc.Infrastructure.Repository
{
    public class BaseRepository<T> : IBase<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<ConstrutoraContext> _optionsBuilder;

        public BaseRepository(DbContextOptions<ConstrutoraContext> optionsBilder)
        {
            _optionsBuilder = optionsBilder;
        }

        public virtual T Add(T obj)
        {
            using (var bd = new ConstrutoraContext(_optionsBuilder))
            {
                bd.Set<T>().Add(obj);
                bd.SaveChanges();
            }
            return obj;
        }

        public virtual T Update(T obj)
        {
            using (var bd = new ConstrutoraContext(_optionsBuilder))
            {
                bd.Set<T>().Update(obj);
                bd.SaveChanges();
            }
            return obj;
        }

        public virtual T Delete(T obj)
        {
            using (var bd = new ConstrutoraContext(_optionsBuilder))
            {
                bd.Set<T>().Remove(obj);
                bd.SaveChanges();
            }
            return obj;
        }

        public virtual void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public virtual T FindById(Guid id)
        {
            using (var bd = new ConstrutoraContext(_optionsBuilder))
            {
                return bd.Set<T>().Find(id);
            }
        }

        public virtual IReadOnlyList<T> ListAll()
        {
            using (var bd = new ConstrutoraContext(_optionsBuilder))
            {
                return bd.Set<T>().AsNoTracking().ToList();
            }
        }

    }
}
