using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MentionController : ControllerBase
    {
        private readonly AiManagerContext _context;
        public MentionController(AiManagerContext context)
        {
            _context = context;

        }


        [HttpGet]
        public async Task<ActionResult <List<Mention>>> GetMentions()
        {
            var mentions = await _context.Mentions!.ToListAsync();

            return Ok(mentions);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Mention>> GetMention(long id)
        {
            return await _context.Mentions!.FindAsync(id);
        }
    }
}