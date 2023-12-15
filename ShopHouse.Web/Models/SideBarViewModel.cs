using ShopHouse.ViewModels.Catalog.Categories;
using System.Collections.Generic;

namespace ShopHouse.Web.Models
{
    public class SideBarViewModel
    {
        public List<CategoryVm> Categories { get; set; }
        public CategoryVm Category { get; set; }
    }
}
