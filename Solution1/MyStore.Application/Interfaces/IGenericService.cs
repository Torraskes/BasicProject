﻿using MyStore.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Application.Interfaces
{
    public interface IGenericService<T> where T : class
    {
        GenericViewModel<T> GetObjects();

    }
}
