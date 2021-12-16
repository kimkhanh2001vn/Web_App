using ShopHouse.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopHouse.ViewModels.Catalog.Products
{
    public class GetManageProductPagingRequest : PagingRequsetBase
    {
        public string keyword { get; set; }
        public string LanguageId { get; set; }
        public int? CategoryId { get; set; }
    }
}
