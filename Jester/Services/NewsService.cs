using Jester.DAL.NewsRepository;
using Jester.Models;

namespace Jester.Services
{

    public class NewsService : INewsService
    {
        private readonly INewsRepository<NewsItem> _newsRepository;

        public NewsService(INewsRepository<NewsItem> newsRepository)
        {
            _newsRepository = newsRepository;
        }

        public async Task<List<NewsItem>> GetLatestNewsItemsAsync()
        {
            return await _newsRepository.GetAllAsync();
        }
        public async Task<NewsItem> GetNewsItemByIdAsync(int id)
        {
            return await _newsRepository.GetByIdAsync(id);
        }
        public async Task CreateNewsItemAsync(NewsItem item)
        {
            await _newsRepository.AddAsync(item);
        }

        public async Task UpdateNewsItemAsync(NewsItem newsItem)
        {
            await _newsRepository.UpdateAsync(newsItem);
        }

        public async Task DeleteNewsItemAsync(int newsItemId)
        {
            await _newsRepository.DeleteAsync(newsItemId);
        }

        public async Task<NewsListViewModel> SearchAndPaginateAsync(string searchTerm, int page = 1, int pageSize = 10)
        {
            List<NewsItem> newsItems = await _newsRepository.GetAllAsync();

            var filteredNews = newsItems.Where(a => a.Title.ToLower().Contains(searchTerm.ToLower() ?? ""));
            var totalItems = filteredNews.Count();

            if (filteredNews.Any())
            {
                var pagedSearchResults = filteredNews.Skip((page - 1) * pageSize).Take(pageSize).ToList();
                var totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

                return new NewsListViewModel
                {
                    NewsItems = pagedSearchResults,
                    CurrentPage = page,
                    TotalPages = totalPages,
                    PageSize = pageSize,
                    SearchTerm = searchTerm
                };
            }
            else
            {
                return null;
            }
        }

        public async Task<List<NewsItem>> GetNewsItemsByCategoryAsync(string category)
        {
            return (await _newsRepository.GetAllAsync()).FindAll(x => x.Category == category);
        }

        public async Task<List<NewsItem>> GetNewsItemsByAuthorAsync(string author)
        {
            return (await _newsRepository.GetAllAsync()).FindAll(x => x.Author == author);
        }

        public async Task<List<string>> GetNewsAuthorsAsync()
        {
            return (await _newsRepository.GetAllAsync()).Select(x => x.Author).ToList();
        }
    }

}
