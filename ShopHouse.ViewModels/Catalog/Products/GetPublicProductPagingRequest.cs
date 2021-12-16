using ShopHouse.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopHouse.ViewModels.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequsetBase
    {
        public int? CategoryId { get; set; }
        public string languageId { get; set; }
    }
}
