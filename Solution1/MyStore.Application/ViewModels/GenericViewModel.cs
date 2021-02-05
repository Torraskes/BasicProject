using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Application.ViewModels
{
    public class GenericViewModel<T> where T : class
    {
        public IEnumerable<T> Objects { get; set; }
        public T Object { get; set; }
    }
}
