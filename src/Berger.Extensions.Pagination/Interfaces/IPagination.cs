namespace Berger.Extensions.Pagination
{
    public interface IPagination<T>
    {
        public int TotalCount { get; set; }
        public int Limit { get; set; }
        public int Current { get; set; }
        public int Pages { get; set; }
        public int Previous { get; set; }
        public int Next { get; set; }
    }
}