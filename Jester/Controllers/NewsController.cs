using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Jester.Models;
using Jester.Services;

namespace Jester.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsService _newsService;

        public NewsController(INewsService context)
        {

            _newsService = context;
        }

        // GET: News
        [Route("/News")]
        public async Task<IActionResult> Index(int page = 1, string? query = null)
        {
            const int pageSize = 10;

            var model = await _newsService.SearchAndPaginateAsync(query ?? "", page, pageSize);

            return model != null ? View(model) : View(new NewsListViewModel()
            {
                CurrentPage = page,
                TotalPages = page,
                PageSize = pageSize,
                NewsItems = new List<NewsItem>(),
                SearchTerm = query
            });
        }

     // GET: News/5
        [HttpGet]
        [Route("/News/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var newsItem = await _newsService.GetNewsItemByIdAsync(id ?? 0);

                if (newsItem == null)
                {
                    return NotFound();
                }

                return View(newsItem);
            }
        }

        [HttpGet]
        [Route("/category/{category}")]
        public async Task<IActionResult> Category(string category)
        {
            var model = new Dictionary<string, string>
            {
                ["Category"] = category
            };

            // ViewComponent inside View will handle fetching all articles matching this category
            return View(model);
        }

        [HttpGet]
        [Route("/tags/{tag}")]
        public async Task<IActionResult> Tags(string tag)
        {
            var model = new Dictionary<string, string>
            {
                ["Tag"] = tag
            };

            // ViewComponent inside View will handle fetching all articles matching this tag
            return View(model);
        }
         
        // GET: News/Create
        [Route("/News/Create")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: News/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("/News/Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Content,Category,DatePublished,Author,IsSponsored,Story")] NewsItem newsItem, string Tags)
        {
            if (ModelState.IsValid)
            {
                newsItem.Tags = Tags.Split(",");
                //newsItem.Story = Story;

                await _newsService.CreateNewsItemAsync(newsItem);
                return RedirectToAction(nameof(Index));
            }
            return View(newsItem);
        }

        // GET: News/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newsItem = await _newsService.GetNewsItemByIdAsync(id);
            if (newsItem == null)
            {
                return NotFound();
            }
            return View(newsItem);
        }

        // POST: News/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content,Category,DatePublished,Author,IsSponsored")] NewsItem newsItem, string Tags)
        {
            if (id != newsItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                newsItem.Tags = Tags.Split(",");

                try
                {
                    await _newsService.UpdateNewsItemAsync(newsItem);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (! (await NewsItemExists(newsItem.Id)))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(newsItem);
        }

        // GET: News/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newsItem = await _newsService.GetNewsItemByIdAsync(id);
            if (newsItem == null)
            {
                return NotFound();
            }

            return View(newsItem);
        }

        // POST: News/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_newsService == null)
            {
                return Problem("Entity set 'NewsContext'  is null.");
            }
            var newsItem = await _newsService.GetNewsItemByIdAsync(id);
            if (newsItem != null)
            {
                await _newsService.DeleteNewsItemAsync(id);
            }

            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> NewsItemExists(int id)
        {
            return (await _newsService.GetNewsItemByIdAsync(id)) != null;
        }
    }
}
