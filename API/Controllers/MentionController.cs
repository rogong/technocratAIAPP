using System.Text.Json;
using API.Dtos;
using API.Entities;
using API.Extensions;
using API.RequestHelpers;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace API.Controllers
{

    public class MentionController : BaseApiController
    {
        private readonly AiManagerContext _context;
         private readonly IMapper _mapper;

        public MentionController(AiManagerContext context, IMapper mapper)
        {

            _mapper = mapper;
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<PagedList<MentionToReturnDto>>> GetMentions([FromQuery] MentionParams mentionParams)
        {
            var query = _context.Mentions
                .Include(m => m.DataSource)
                .Include(m => m.Language)
                .Include(m => m.Market)
                .Include(m => m.Product)
                .Include(m => m.Region)
                .Sort(mentionParams.OrderBy)
                .Search(mentionParams.SearchTerm)
                .Filter(mentionParams.DataSources, mentionParams.Regions,
                mentionParams.Markets,mentionParams.Products,mentionParams.Languages)
                .AsQueryable();

               

            var mentions = await PagedList<Mention>.ToPagedList(query,
                mentionParams.PageNumber, mentionParams.PageSize);

                

                 Response.AddPaginationHeader(mentions.MetaData);

                  var data = _mapper.Map<IReadOnlyList<Mention>, IReadOnlyList<MentionToReturnDto>>(mentions);
            
                return Ok(data);
        }

        [HttpGet("filters")]
        public async Task<IActionResult> GetFilters()
        {
            var datasources = await _context.Mentions.Select(m => m.DataSource.SourceName).Distinct().ToListAsync();
            var markets = await _context.Mentions.Select(m => m.Market.Name).Distinct().ToListAsync();
            var regions = await _context.Mentions.Select(m => m.Region.Name).Distinct().ToListAsync();
            var products = await _context.Mentions.Select(m => m.Product.ProductName).Distinct().ToListAsync();
            var languages = await _context.Mentions.Select(m => m.Language.DisplayName).Distinct().ToListAsync();

            return Ok(new {datasources, markets, regions, products, languages});
            
        }
    }
}