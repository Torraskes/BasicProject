using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStore.Application.Interfaces;
using MyStore.Application.ViewModels;
using MyStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductGenericController : ControllerBase
    {
        private readonly IGenericService<Product> _genericService;
        public ProductGenericController(IGenericService<Product> genericService)
        {
            this._genericService = genericService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(this._genericService.GetObjects());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(this._genericService.ObjectByID(id));
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] GenericViewModel<Product> newProd)
        {
            return Ok(this._genericService.AddObject(newProd));
        }

        [HttpPut]
        public IActionResult UpProduct([FromBody] GenericViewModel<Product> upProd)
        {
            return Ok(this._genericService.UpObject(upProd));
        }

        [HttpDelete("{id}")]
        public IActionResult delProduct(int id)
        {
            return Ok(this._genericService.DelObject(id));
        }
    }
}
