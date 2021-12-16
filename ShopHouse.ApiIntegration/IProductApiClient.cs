using ShopHouse.ViewModels.Catalog.Products;
using ShopHouse.ViewModels.Common;
using ShopHouse.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHouse.ApiIntegration
{
    public interface IProductApiClient
    {
        Task<PagedResult<ProductVm>> GetPagings(GetManageProductPagingRequest request);
        Task<bool> CreateProduct(ProductCreateRequest request);
        Task<bool> UpdateProduct(ProductUpdateRequest request);
        Task<ProductVm> GetById(int id, string languageId);
        Task<ApiResult<bool>> CategoryAssign(int id,CategoryAssignRequest request);
        Task<List<ProductVm>> GetfeaturedProducts(string languageId, int take);
        Task<List<ProductVm>> GetPopularproducts(string languageId, int take);
        Task<List<ProductVm>> ProductByCategories(string languageId, int take);
    }
}
