using ShopHouse.ViewModels.Catalog.Categories;
using ShopHouse.ViewModels.Catalog.Products;
using ShopHouse.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHouse.Web.Models
{
    public class ProductCategoryViewModel
    {
        public CategoryVm Category { get; set; }

        public PagedResult<ProductVm> Products { get; set; }
    }
}
