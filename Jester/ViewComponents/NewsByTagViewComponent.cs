using Jester.Models;
using Jester.Services;
using Microsoft.AspNetCore.Mvc;

namespace Jester.ViewComponents
{
    public class NewsByTagViewComponent : ViewComponent
    {
        private readonly INewsService _newsService;
        public NewsByTagViewComponent(INewsService newsService)
        {
            _newsService = newsService;
        }
        public async Task<IViewComponentResult> InvokeAsync(string tag, string? noResultsText)
        {

            if (!String.IsNullOrWhiteSpace(tag))
            {
                var newsItemsByTag = await _newsService.GetNewsItemsByTagAsync(tag);

                return View(new FilteredBlockViewModel() { NoResultsText = noResultsText, Items = newsItemsByTag });
            }
            
            return View(new FilteredBlockViewModel() { NoResultsText = noResultsText });
        }
    }
}
