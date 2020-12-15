using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductService.Models;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsAPIController : ControllerBase
    {
        ProductsDb products;
        public ProductsAPIController()
        {
            products = new ProductsDb();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(products);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Product prd)
        {
            products.Add(prd);
            return Ok(products);
        }
    }
}