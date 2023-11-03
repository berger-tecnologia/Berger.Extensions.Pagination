namespace Berger.Extensions.Pagination
{
    public class PageInformation : IPageInformation
    {
        public bool HasNextPage { get; set; }
        public bool HasPreviousPage { get; set; }
    }
}