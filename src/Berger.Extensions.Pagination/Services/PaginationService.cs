namespace Berger.Extensions.Pagination
{
    public static class PaginationService
    {
        public static Pagination<T> Paginate<T>(this Pagination<T> pagination, int current) where T : class
        {
            var pages = (double)pagination.TotalCount / pagination.Limit;

            var round = (int)Math.Ceiling(pages);

            pagination.Current = current;
            pagination.Pages = round;

            if (current > round)
            {
                pagination.Previous = round - 1;
                pagination.Next = round;
            }
            else
            {
                pagination.Previous = (current - 1 <= 0) ? 1 : current - 1;
                pagination.Next = (current + 1 >= round + 1) ? round : current + 1;
            }

            return pagination;
        }
        public static Pagination<T> Paginate<T>(this IList<T> list, int page, int limit) where T : class
        {
            return list.AsQueryable().Paginate(page, limit);
        }
        public static Pagination<T> Paginate<T>(this IQueryable<T> query, int page, int limit) where T : class
        {
            var pagination = new Pagination<T>();

            var records = query.Count();
            var pages = (double)records / limit;
            var round = (int)Math.Ceiling(pages);
            var skip = (page - 1) * limit;

            var results = query.Count() <= limit ? query : query.Skip(skip).Take(limit);

            var pageInfo = new PageInformation()
            {
                HasNextPage = round >= page + 1,
                HasPreviousPage = page > 1
            };

            pagination.TotalCount = records;
            pagination.Limit = limit;
            pagination.Items = results.ToList();
            pagination.Current = page;
            pagination.Pages = round;

            pagination.PageInformation = pageInfo;

            if (page > round)
            {
                pagination.Previous = round - 1;
                pagination.Next = round;
            }
            else
            {
                pagination.Previous = (page - 1 <= 0) ? 1 : page - 1;
                pagination.Next = (page + 1 >= round + 1) ? round : page + 1;
            }

            return pagination;
        }
    }
}