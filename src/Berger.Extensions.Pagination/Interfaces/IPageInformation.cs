namespace Berger.Extensions.Pagination
{
    public interface IPageInformation
    {
        bool HasNextPage { get; set; }
        bool HasPreviousPage { get; set; }
    }
}