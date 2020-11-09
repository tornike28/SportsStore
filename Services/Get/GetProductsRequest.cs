namespace SportsStore.services
{
    public class GetProductsRequest
    {
        public int PageSize { get; set; }
        public int Page { get; set; }
        public string CategoryName { get; set; }
    }
}