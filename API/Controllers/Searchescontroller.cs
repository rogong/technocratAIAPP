using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{

    public class Searchescontroller : BaseApiController
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