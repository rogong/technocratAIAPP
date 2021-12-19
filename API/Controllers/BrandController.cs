using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    
    public class BrandController : BaseApiController
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