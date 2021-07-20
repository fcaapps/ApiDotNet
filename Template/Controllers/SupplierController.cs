using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Template.Application.Interfaces;
using Template.Application.ViewModels;
using Template.Domain.Entities;
using Template.Domain.Validator;

namespace Template.Controllers
{
    [EnableCors("CorsApi")]
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {

        private readonly ISupplierService supplierService;

        public SupplierController(ISupplierService supplierService)
        {
            this.supplierService = supplierService;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(this.supplierService.Get());
        }

        [HttpPost]
        public IActionResult Post(SupplierViewModel supplierViewModel)
        {
            
            return Ok(this.supplierService.Post(supplierViewModel));
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            return Ok(this.supplierService.GetById(id));
        }

        [HttpPut]
        public IActionResult Put(SupplierViewModel supplierViewModel)
        {
            return Ok(this.supplierService.Put(supplierViewModel));
        }

        [HttpDelete]
        public IActionResult Delete(string id)
        {
            return Ok(this.supplierService.Delete(id));
        }
    }
}
