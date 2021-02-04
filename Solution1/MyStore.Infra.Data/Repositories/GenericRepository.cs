using Microsoft.EntityFrameworkCore;
using MyStore.Domain.Interfaces;
using MyStore.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyStore.Infra.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private MyStoreDBContext _context;
        private DbSet<T> table;
        public GenericRepository(MyStoreDBContext context)
        {
            this._context = context;
            table = this._context.Set<T>();
        }
        public T Add(T newObj)
        {
            this.table.Add(newObj);
            this._context.SaveChanges();
            return newObj;
        }

        public T Delete(object Id)
        {
            T Element = this.table.Find(Id);
            this.table.Remove(Element);
            this._context.SaveChanges();
            return Element;
        }

        public List<T> GetAll()
        {
            return this.table.ToList();
        }

        public T TGetBtID(object Id)
        {
            return this.table.Find(Id);
        }

        public T Update(T upObj)
        {
            this.table.Attach(upObj);
            this._context.Entry(upObj).State = EntityState.Modified;
            this._context.SaveChanges();
            return upObj;
        }
    }
}
