namespace Jester.Models
{
    public class NewsListViewModel
    {
        public List<NewsItem> NewsItems { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        
        public string? SearchTerm { get; set; }
    }
}
