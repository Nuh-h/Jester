using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    /*
        // GET: NewsItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NewsItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Content,Category,DatePublished,Author,IsSponsored,Tags")] NewsItem newsItem)
        {
            if (ModelState.IsValid)
            {
                _newsService.Add(newsItem);
                await _newsService.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(newsItem);
        }

        // GET: NewsItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _newsService.NewsItems == null)
            {
                return NotFound();
            }

            var newsItem = await _newsService.NewsItems.FindAsync(id);
            if (newsItem == null)
            {
                return NotFound();
            }
            return View(newsItem);
        }

        // POST: NewsItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content,Category,DatePublished,Author,IsSponsored,Tags")] NewsItem newsItem)
        {
            if (id != newsItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _newsService.Update(newsItem);
                    await _newsService.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewsItemExists(newsItem.Id))
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

        // GET: NewsItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _newsService.NewsItems == null)
            {
                return NotFound();
            }

            var newsItem = await _newsService.NewsItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (newsItem == null)
            {
                return NotFound();
            }

            return View(newsItem);
        }

        // POST: NewsItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_newsService == null)
            {
                return Problem("Entity set 'NewsContext'  is null.");
            }
            var newsItem = await _newsService.FindAsync(id);
            if (newsItem != null)
            {
                _newsService.Remove(newsItem);
            }

            await _newsService.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NewsItemExists(int id)
        {
            return (_newsService.NewsItems?.Any(e => e.Id == id)).GetValueOrDefault();
        }*/
    }
}
