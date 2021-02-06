using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStore.Application.Interfaces;
using MyStore.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;


        public ProductController(IProductService productService)
        {
            this._productService = productService;            
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(this._productService.GetProducts());
        }        

        [HttpGet("{id}")]
        public IActionResult Get(int Id)
        {
            return Ok(this._productService.ProductByID(Id));
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] ProductViewModel productViewModel)
        {
            return Ok(this._productService.AddProduct(productViewModel));
        }

        [HttpPut]
        public IActionResult Put([FromBody] ProductViewModel productViewModel)
        {
            return Ok(this._productService.UpProduct(productViewModel));
        }

        [HttpDelete("{id}")]
        public IActionResult delete(int Id)
        {
            return Ok(this._productService.DelProduct(Id));
        }

    }
}
