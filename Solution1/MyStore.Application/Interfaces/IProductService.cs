using MyStore.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Application.Interfaces
{
    public interface IProductService
    {
        ProductViewModel GetProducts();
        ProductViewModel ProductByID(int Id);
        ProductViewModel AddProduct(ProductViewModel newProd);
        ProductViewModel DelProduct(int Id);
        ProductViewModel UpProduct(ProductViewModel newProd);

    }
}
