using Jester.Data;
using Jester.Models;
using Microsoft.EntityFrameworkCore;

namespace Jester.DAL.NewsRepository
{
    public class NewsRepository : INewsRepository<NewsItem>
    {
        private readonly NewsContext _newsContext;

        public NewsRepository(NewsContext newsContext)
        {
            _newsContext = newsContext;
        }

        public async Task AddAsync(NewsItem newsItem)
        {
            await _newsContext.NewsItems.AddAsync(newsItem);
            await _newsContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var newsItem = await GetByIdAsync(id);
            if (newsItem != null)
            {
                _newsContext.NewsItems.Remove(newsItem);
                await _newsContext.SaveChangesAsync();
            }
        }

        public async Task<List<NewsItem>> GetAllAsync()
        {
            return await _newsContext.NewsItems.ToListAsync();
        }

        public async Task<NewsItem?> GetByIdAsync(int id)
        {
            return await _newsContext.NewsItems.FindAsync(id) ?? null;
        }

        public async Task UpdateAsync(NewsItem newsItem)
        {
            _newsContext.NewsItems.Update(newsItem);
            await _newsContext.SaveChangesAsync();
        }

    }
}
