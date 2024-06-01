namespace Jester.Models
{
    public class FilteredBlockViewModel
    {
        public string? NoResultsText { get; set; }
        public List<NewsItem> Items { get; set; }

        public FilteredBlockViewModel()
        {
            Items = new List<NewsItem>();
        }
    }
}
