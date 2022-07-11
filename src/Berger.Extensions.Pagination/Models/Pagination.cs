namespace Berger.Extensions.Pagination
{
    public class Pagination<T> where T : class
    {
        public List<T> Items { get; set; } = new List<T>();
        public int Limit { get; set; }
        public int Pages { get; set; }
        public int TotalCount { get; set; }
        public PageInfo PageInfo { get; set; } = new PageInfo();
    }
}