using Jester.Data;
using Jester.Models;
using Jester.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Jester.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INewsService _newsService;

        public HomeController(ILogger<HomeController> logger, INewsService context)
        {
            _logger = logger;
            _newsService = context;
        }

        public async Task<IActionResult> Index()
        {
            List<NewsItem> newsItems = await _newsService.GetLatestNewsItemsAsync();

            var model = new NewsListViewModel
            {
                NewsItems = newsItems,
                CurrentPage = 1,
                TotalPages = newsItems.Count,
                PageSize = 10,
                SearchTerm = null
            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}