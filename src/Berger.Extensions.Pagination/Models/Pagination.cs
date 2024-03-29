﻿using Berger.Extensions.Abstractions;

namespace Berger.Extensions.Pagination
{
    public class Pagination<T> : IPagination<T> where T : class
    {
        public int Current { get; set; } = 1;
        public List<T> Items { get; set; } = new List<T>();
        public int Limit { get; set; } = 50;
        public int Pages { get; set; } = 1;
        public int TotalCount { get; set; } = 0;
        public int Previous { get; set; } = 0;
        public int Next { get; set; } = 0;
        public IPageInformation PageInformation { get; set; }
    }
}