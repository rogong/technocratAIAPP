using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BrandController : ControllerBase
    {
        private readonly AiManagerContext _context;
        public BrandController(AiManagerContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult <List<Brand>> GetBrands()
        {
            var brands = _context.Brands.ToList();

            return Ok(brands);
        }

         [HttpGet("{id}")]
        public ActionResult<Brand> GetBrand(int id)
        {
            return _context.Brands.Find(id);
        }
    }
}