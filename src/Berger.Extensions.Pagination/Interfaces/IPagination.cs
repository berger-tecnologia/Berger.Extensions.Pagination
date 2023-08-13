namespace Berger.Extensions.Pagination
{
    public interface IPagination<T> where T : class
    {
        Pagination<T> Get(string query, int page = 0);
        Pagination<T> Get(string query, int page = 0, object filters = null);
    }
}