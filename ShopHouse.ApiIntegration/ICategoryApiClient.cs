using ShopHouse.ViewModels.Catalog.Categories;
using ShopHouse.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHouse.ApiIntegration
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryVm>> GetAll(string languageId);
        Task<CategoryVm> GetById(string languageId, int id);
    }
}
