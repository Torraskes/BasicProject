using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Domain.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        T TGetBtID(object Id);
        List<T> GetAll();
        T Add(T newObj);
        T Update(T upObj);
        T Delete(object Id);
    }
}
