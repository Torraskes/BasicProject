using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyStore.Application.Interfaces;
using MyStore.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.MVC.Controllers
{
    [Authorize]
    public class Productcontroller : Controller
    {
        private IProductService _productService;

        public Productcontroller(IProductService productServic)
        {
            _productService = productServic;
        }


        public IActionResult Index()
        {
            ProductViewModel model = this._productService.GetProducts();
            return View(model);
        }
    }
}
