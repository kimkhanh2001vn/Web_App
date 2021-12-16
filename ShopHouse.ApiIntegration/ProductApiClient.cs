using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using ShopHouse.Utilities.Constants;
using ShopHouse.ViewModels.Catalog.Categories;
using ShopHouse.ViewModels.Catalog.Products;
using ShopHouse.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ShopHouse.ApiIntegration
{
    public class ProductApiClient : BaseApiClient , IProductApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        public ProductApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
            : base(httpClientFactory,configuration,httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request)
        {
            var session = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var json = JsonConvert.SerializeObject(request);

            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration.GetSection("BaseAddress").Value);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session);

            var response = await client.PutAsync($"/api/products/{id}/categories", httpContent);
            var result = await response.Content.ReadAsStringAsync();
            //connection Api
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ApiSuccessResult<bool>>(result);
            }
            return JsonConvert.DeserializeObject<ApiErrorResult<bool>>(result);
        }

        public async Task<bool> CreateProduct(ProductCreateRequest request)
        {
            var sessions = _httpContextAccessor.HttpContext.Session.GetString(SystemConstants.Appsettings.Token);

            var languageId = _httpContextAccessor.HttpContext.Session.GetString(SystemConstants.Appsettings.DefaultLangueId);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.Appsettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var requestContent = new MultipartFormDataContent();

            if (request.ThumbnailImage != null)
            {
                byte[] data;
                using (var br = new BinaryReader(request.ThumbnailImage.OpenReadStream()))
                {
                    data = br.ReadBytes((int)request.ThumbnailImage.OpenReadStream().Length);
                }
                ByteArrayContent bytes = new ByteArrayContent(data);
                requestContent.Add(bytes, "thumbnailImage", request.ThumbnailImage.FileName);
            }
            requestContent.Add(new StringContent(request.Price.ToString()), "Price");
            requestContent.Add(new StringContent(request.OriginalPrice.ToString()), "OriginalPrice");
            requestContent.Add(new StringContent(request.Stock.ToString()), "Stock");
            requestContent.Add(new StringContent(request.Name.ToString()), "Name");
            requestContent.Add(new StringContent(request.Description.ToString()), "Description");
            requestContent.Add(new StringContent(request.Details.ToString()), "Details");

            requestContent.Add(new StringContent(request.SeoDescription.ToString()), "SeoDescription");
            requestContent.Add(new StringContent(request.SeoTitle.ToString()), "SeoTitle");
            requestContent.Add(new StringContent(request.SeoAlias.ToString()), "SeoAlias");

            requestContent.Add(new StringContent(languageId), "LanguageId");

            var response = await client.PostAsync($"/api/products/", requestContent);
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> UpdateProduct(ProductUpdateRequest request)
        {
            var sessions = _httpContextAccessor.HttpContext.Session.GetString(SystemConstants.Appsettings.Token);

            var languageId = _httpContextAccessor.HttpContext.Session.GetString(SystemConstants.Appsettings.DefaultLangueId);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.Appsettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var requestContent = new MultipartFormDataContent();

            if (request.ThumbnailImage != null)
            {
                byte[] data;
                using (var br = new BinaryReader(request.ThumbnailImage.OpenReadStream()))
                {
                    data = br.ReadBytes((int)request.ThumbnailImage.OpenReadStream().Length);
                }
                ByteArrayContent bytes = new ByteArrayContent(data);
                requestContent.Add(bytes, "thumbnailImage", request.ThumbnailImage.FileName);
            }
            requestContent.Add(new StringContent(request.Name.ToString()), "Name");
            requestContent.Add(new StringContent(request.Description.ToString()), "Description");
            requestContent.Add(new StringContent(request.Details.ToString()), "Details");

            requestContent.Add(new StringContent(request.SeoDescription.ToString()), "SeoDescription");
            requestContent.Add(new StringContent(request.SeoTitle.ToString()), "SeoTitle");
            requestContent.Add(new StringContent(request.SeoAlias.ToString()), "SeoAlias");

            requestContent.Add(new StringContent(languageId), "LanguageId");

            var response = await client.PutAsync($"/api/products/" + request.Id, requestContent);
            return response.IsSuccessStatusCode;
        }
        public async Task<ProductVm> GetById(int id, string languageId)
        {
            return await GetAsync<ProductVm>($"/api/products/{id}/{languageId}");
        }

        public async Task<List<ProductVm>> GetfeaturedProducts(string languageId, int take)
        {
            return await GetListAsync<ProductVm>($"/api/products/featured/{languageId}/{take}");
        }

        public async Task<PagedResult<ProductVm>> GetPagings(GetManageProductPagingRequest request)
        {
            return await GetAsync<PagedResult<ProductVm>>(
                $"/api/products/paging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&keyword={request.keyword}" +
                $"&languageId={request.LanguageId}" +
                $"&categoryId={request.CategoryId}");
        }

        public async Task<List<ProductVm>> GetPopularproducts(string languageId, int take)
        {
            return await GetListAsync<ProductVm>($"/api/products/popular/{languageId}/{take}");
        }

        public async Task<List<ProductVm>> ProductByCategories(string languageId, int take)
        {
            return await GetListAsync<ProductVm>($"/api/products/productbycategories/{languageId}/{take}");
        }
    }
}
