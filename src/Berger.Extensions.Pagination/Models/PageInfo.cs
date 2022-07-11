namespace Berger.Extensions.Pagination.Models
{
    public class PageInfo
    {
        public int Current { get; set; }
        public bool HasPreviousPage { get; set; }
        public int Previous { get; set; }
        public bool HasNextPage { get; set; }
        public int Next { get; set; }
    }
}
