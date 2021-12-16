using ShopHouse.ViewModels.Catalog.Categories;
using ShopHouse.ViewModels.Catalog.ProductInCategories;
using ShopHouse.ViewModels.Catalog.Products;
using ShopHouse.ViewModels.Common;
using ShopHouse.ViewModels.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHouse.Web.Models
{
    public class HomeViewModel
    {
        public List<SlideVm> slides { get; set; }
        public List<ProductVm> Featureproducts { get; set; }
        public List<ProductVm> Popularproducts { get; set; }
        public List<CategoryVm> Categories { get; set; }
        public CategoryVm Category { get; set; }
        public PagedResult<ProductVm> Products { get; set; }
        
    }
}
