using Jester.Models;

namespace Jester.Services
{
    public interface INewsService
    {
        Task<List<NewsItem>> GetLatestNewsItemsAsync();
        Task<NewsItem> GetNewsItemByIdAsync(int newsItemId);
        Task CreateNewsItemAsync(NewsItem newsItem);
        Task UpdateNewsItemAsync(NewsItem newsItem);
        Task DeleteNewsItemAsync(int newsItemId);

        Task<NewsListViewModel> SearchAndPaginateAsync(string searchTerm, int page, int pageSize);

        Task<List<NewsItem>> GetNewsItemsByCategoryAsync(string category, int? currentId);
        Task<List<NewsItem>> GetNewsItemsByTagAsync(string tag);
        Task<List<NewsItem>> GetNewsItemsByAuthorAsync(string category);
        Task<List<string>> GetNewsAuthorsAsync();

    }
}
