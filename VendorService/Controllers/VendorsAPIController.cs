using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VendorService.Models;

namespace VendorService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorsAPIController : ControllerBase
    {
        VendorsDb vendors;

        public VendorsAPIController()
        {
            vendors = new VendorsDb();
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(vendors);
        }

    }
}