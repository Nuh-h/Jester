using Jester.Models;
using Jester.Services;
using Microsoft.AspNetCore.Mvc;

namespace Jester.ViewComponents
{
    public class NewsByCategoryViewComponent : ViewComponent
    {
        private readonly INewsService _newsService;
        public NewsByCategoryViewComponent(INewsService newsService)
        {
            _newsService = newsService;
        }
        public async Task<IViewComponentResult> InvokeAsync(string category, int? currentId, string? noResultsText, string? author)
        {

            var newsItemsByCategory = await _newsService.GetNewsItemsByCategoryAsync(category, currentId);

            if(newsItemsByCategory == null && !String.IsNullOrWhiteSpace(author))
            {
                var newsItemsByAuthor = await _newsService.GetNewsItemsByAuthorAsync(author);
                return View(new FilteredBlockViewModel() { NoResultsText = noResultsText, Items = newsItemsByAuthor});
            }

            return View(new FilteredBlockViewModel() { NoResultsText = noResultsText, Items = newsItemsByCategory});
        }
    }
}
