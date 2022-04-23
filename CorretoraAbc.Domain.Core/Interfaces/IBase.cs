using System;
using System.Collections.Generic;

namespace CorretoraAbc.Domain.Core.Interfaces
{
    public interface IBase<T> where T : class
    {
        T Add(T obj);

        T Update(T obj);

        T FindById(Guid id);

        T Delete(T obj);

        IReadOnlyList<T> ListAll();

    }
}
