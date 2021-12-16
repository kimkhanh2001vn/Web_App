
using Microsoft.AspNetCore.Http;
using ShopHouse.ViewModels.Catalog.Products;
using ShopHouse.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopHouse.Application.Catalog.Products
{
    public interface IProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);
        Task<ProductVm> GetById(int productId,string languageId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewCount(int productId);

        Task<PagedResult<ProductVm>> GetAllPaging(GetManageProductPagingRequest requset);
        Task<int> AddImages(int productId, List<IFormFile> file);
        Task<int> RemoveImages(int imageId);
        Task<int> updateImage(int imageId, string caption, bool isDefault);
        Task<List<ProductImageViewModel>> GetListImage(int productId);
        Task<ApiResult<bool>> CategoryAssign(int id,CategoryAssignRequest request);
        Task<PagedResult<ProductVm>> GetAllByCategoryId(GetPublicProductPagingRequest request);
        Task<List<ProductVm>> GetAll(string languageId);
        Task<List<ProductVm>> GetfeaturedProducts(string languageId, int take);
        Task<List<ProductVm>> GetpopularProducts(string languageId, int take);
    }
}