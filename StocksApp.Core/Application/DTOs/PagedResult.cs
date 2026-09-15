namespace StocksApp.Core.Application.DTOs
{
    public class PagedResult<T> where T : class
    {
        public List<T>? Items{ get; set; }
        public OrderCursor? Cursor { get; set; }
        public bool HasNextPage { get; set; }
    }
}
