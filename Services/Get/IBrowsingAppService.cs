using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.services
{
    public interface IbrowsingAppservice
    {
        public GetProductsResponse GetProducts(GetProductsRequest request);
        public GetPicturesResponse GetPictures(GetPicturesRequest request);
        public GetProductsDetailsResponse GetPicturesDetails(GetProductsDetailsRequest request);
    }
}
