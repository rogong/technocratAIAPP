using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Interface;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class MentionRepository : IMentionRepository
    {
        private readonly AiManagerContext _context;
        public MentionRepository(AiManagerContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<DataSource>> GetDataSourcesAsync()
        {
            return await _context.DataSources
            .ToListAsync();
        }

        public async Task<IReadOnlyList<AbpLanguage>> GetLanguagesAsync()
        {
            return await _context.AbpLanguages.ToListAsync();
        }

        public async Task<IReadOnlyList<Market>> GetMarketsAsync()
        {
            return await _context.Markets.ToListAsync();
        }

        public async Task<Mention> GetMentionByIdAsync(long id)
        {
            return await _context.Mentions.FindAsync(id);
        }

        public async Task<IReadOnlyList<Mention>> GetMentionsAsync()
        {
            return await _context.Mentions
            .Include(m => m.DataSource)
            .Include(m => m.Language)
            .Include(m => m.Market)
            .Include(m => m.Product)
            .Include(m => m.Region)
            .ToListAsync();
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<IReadOnlyList<Region>> GetRegionsAsync()
        {
            return await _context.Regions.ToListAsync();
        }
    }
}