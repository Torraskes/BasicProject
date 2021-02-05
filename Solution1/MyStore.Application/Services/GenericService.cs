
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

        public GenericViewModel<T> AddObject(GenericViewModel<T> newObject)
        {
            return new GenericViewModel<T>()
            {
                Object = this._genericRepository.Add(newObject.Object)
            };
        }

        public GenericViewModel<T> DelObject(int Id)
        {
            return new GenericViewModel<T>()
            {
                Object = this._genericRepository.Delete(Id)
            };
        }

        public GenericViewModel<T> GetObjects()
        {
            return new GenericViewModel<T>()
            {
                Objects = this._genericRepository.GetAll()
            };            
        }

        public GenericViewModel<T> ObjectByID(int Id)
        {
            return new GenericViewModel<T>()
            {
                Object = this._genericRepository.TGetBtID(Id)
            };
        }

        public GenericViewModel<T> UpObject(GenericViewModel<T> upObject)
        {
            return new GenericViewModel<T>()
            {
                Object = this._genericRepository.Update(upObject.Object)
            };
        }
    }
}
