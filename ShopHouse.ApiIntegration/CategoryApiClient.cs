using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using ShopHouse.ViewModels.Catalog.Categories;
using ShopHouse.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShopHouse.ApiIntegration
{
    public class CategoryApiClient : BaseApiClient , ICategoryApiClient
    {
        public CategoryApiClient(IHttpClientFactory httpClientFactory,
            IConfiguration iconfiguration,
            IHttpContextAccessor httpContextAccessor)
            : base(httpClientFactory, iconfiguration, httpContextAccessor)
        {
        }
        public async Task<List<CategoryVm>> GetAll(string languageId)
        {
            var data = await GetListAsync<CategoryVm>($"/api/categories/{languageId}");
            return data;
        }
        public async Task<CategoryVm> GetById(string languageId, int id)
        {
            return await GetAsync<CategoryVm>($"/api/categories/{id}/{languageId}");
        }
    }
}
