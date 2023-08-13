namespace Berger.Extensions.Pagination
{
    public interface IPagination<T> where T : class
    {
        Task<Pagination<T>> Get(string query, int page = 0);
        Task<Pagination<T>> Get(string query, int page = 0, object filters = null);
    }
}