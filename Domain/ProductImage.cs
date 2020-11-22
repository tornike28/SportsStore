using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Domain
{
    public class ProductImage
    {
        public int ProductImageId { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public string ImageUrl { get; set; }
        public bool IsThumbnail { get; set; }
        public ProductImage(
                      int productImageId,
                      int productID,
                      string imageUrl,
                      bool isThumbnail)
        {
            ProductImageId = productImageId;
            ProductID = productID;
            ImageUrl = imageUrl;
            IsThumbnail = isThumbnail;
        }
    }
}
