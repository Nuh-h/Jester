namespace Jester.Models
{
    public class PaginationViewModel
    {
        public int PageIndex { get; set;} = 1;
        public int PageSize { get; set;}
        public int PageCount { get; set;}

        public string AriaLabel { get; set;}
        public string AriaControls { get; set; }

    }
}
