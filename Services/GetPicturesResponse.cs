using System.Collections.Generic;

namespace SportsStore.services
{
    public class GetPicturesResponse
    {
        public int ProductId { get; set; }
        public string ImageUrls { get; set; }
        public List<GetPicturesResponse> Pictures { get; internal set; }
    }
}