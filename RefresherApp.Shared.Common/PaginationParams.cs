namespace RefresherApp.Shared.Common
{
    public class PaginationParams
    {
        public int Page { get; set; } = 1;
        public int Count { get; set; } = 0;
        public int TotalCount { get; set; } = 0;
        public int Prev {  get; set; }
        public int Next { get; set; }

    }
}
