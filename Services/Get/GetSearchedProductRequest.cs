namespace SportsStore.services
{
    public class GetSearchedProductRequest
    {
        public string Search { get; set; }
        public int PageSize { get; set; }
        public int Page { get; set; }
    }
}