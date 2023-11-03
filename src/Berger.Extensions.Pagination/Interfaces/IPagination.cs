namespace Berger.Extensions.Pagination
{
    public interface IPagination<T> where T : class
    {
        int Current { get; set; }
        List<T> Items { get; set; }
        int Limit { get; set; }
        int Pages { get; set; }
        int TotalCount { get; set; }
        int Previous { get; set; }
        int Next { get; set; }
        IPageInformation PageInformation { get; set; }
    }
}