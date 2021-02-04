
using MyStore.Application.Interfaces;
using MyStore.Application.ViewModels;
using MyStore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;



namespace MyStore.Application.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private IGenericRepository<T> _genericRepository;

        public GenericService(IGenericRepository<T> genericRepository)
        {
            this._genericRepository = genericRepository;
        }
        public GenericViewModel<T> GetObjects()
        {
            return new GenericViewModel<T>()
            {
                Objects = this._genericRepository.GetAll()
            };            
        }
    }
}
