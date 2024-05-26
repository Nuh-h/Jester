using Jester.Models;
using Jester.Services;
using Microsoft.AspNetCore.Mvc;

namespace Jester
{
    public class AuthorsController : Controller
    {

        private readonly INewsService _newsService;
        public AuthorsController(INewsService context)
        {
            _newsService = context;
        }

        public async Task<IActionResult> Index()
        {
            var authors = await _newsService.GetNewsAuthorsAsync();
            return View(authors);
        }

        [Route("/authors/{name}")]
        public async Task<IActionResult> Profile(string name)
        {
            var articles = await _newsService.GetNewsItemsByAuthorAsync(name);

            if(articles == null)
            {
                return NotFound();
            }else
            {
                return View(new AuthorViewModel()
                {
                    Name = name,
                    Articles = articles
                });
            }
        }
    }
}
