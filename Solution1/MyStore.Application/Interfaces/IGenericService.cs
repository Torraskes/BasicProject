using MyStore.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Application.Interfaces
{
    public interface IGenericService<T> where T : class
    {
        GenericViewModel<T> GetObjects();

        GenericViewModel<T> ObjectByID(int Id);
        GenericViewModel<T> AddObject(GenericViewModel<T> newProd);
        GenericViewModel<T> DelObject(int Id);
        GenericViewModel<T> UpObject(GenericViewModel<T> newProd);

    }
}
