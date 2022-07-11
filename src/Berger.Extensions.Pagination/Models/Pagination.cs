namespace Berger.Extensions.Pagination.Models
{
    public class Pagination<T> where T : class
    {
        public IList<T> Items { get; set; } = new List<T>();
        public int Limit { get; set; }
        public int Pages { get; set; }
        public int TotalCount { get; set; }
        public PageInfo PageInfo { get; set; } = new PageInfo();
    }
}