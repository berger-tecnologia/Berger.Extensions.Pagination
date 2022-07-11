using Berger.Extensions.Pagination.Models;

namespace Berger.Extensions.Pagination.Services
{
    public static class PaginationExtension
    {
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

            var pageInfo = new PageInfo()
            {
                Current = page,
                Previous = (page - 1 == 0) ? 1 : page - 1,
                Next = (page + 1 == round + 1) ? round : page + 1,
                HasNextPage = round >= page + 1,
                HasPreviousPage = page > 1
            };

            pagination.TotalCount = records;
            pagination.Limit = limit;
            pagination.Pages = round;
            pagination.Items = results.ToList();

            pagination.PageInfo = pageInfo;

            return pagination;
        }
    }
}
