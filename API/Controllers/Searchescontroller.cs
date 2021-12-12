using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Searchescontroller : ControllerBase
    {
        private readonly AiManagerContext _context;
        public Searchescontroller(AiManagerContext context)
        {
            _context = context;
            
        }

        [HttpGet]
        public async Task<ActionResult<List<Search>>> GetSearches()
        {
            var searches = await _context.Searches!.ToListAsync();

            return Ok(searches);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Search>> GetSearch(long id)
        {
            return await _context.Searches!.FindAsync(id);
        }
      
    }
}