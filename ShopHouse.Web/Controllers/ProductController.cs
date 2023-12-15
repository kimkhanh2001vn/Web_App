using Microsoft.AspNetCore.Mvc;
using ShopHouse.ApiIntegration;
using ShopHouse.ViewModels.Catalog.Products;
using ShopHouse.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHouse.Web.Controllers
{
    public class ProductController : Controller
    {
        #region Call Service
        private readonly IProductApiClient _productApiClient;
        private readonly ICategoryApiClient _categoryApiClient;

        public ProductController(IProductApiClient productApiClient, ICategoryApiClient categoryApiClient)
        {
            _productApiClient = productApiClient;
            _categoryApiClient = categoryApiClient;
        }
        #endregion

        public async Task<IActionResult> Detail(int id, string culture)
        {
            var products = await _productApiClient.GetById(id, culture);
            await _productApiClient.UpdateViewCount(id);
            return View(new ProductDetailViewModel()
            {
                Product = products,
                Category = await _categoryApiClient.GetById(culture, id)
            });
        }
        public async Task<IActionResult> Category(int id, string culture, int page = 1, string keyword = null)
        {
            var products = await _productApiClient.GetPagings(new GetManageProductPagingRequest()
            {
                CategoryId = id,
                PageIndex = page,
                LanguageId = culture,
                PageSize = 10,
                keyword = keyword
            });

            if (keyword != null)
                ViewBag.keyword = keyword;

            return View(new ProductCategoryViewModel()
            {
                Category = await _categoryApiClient.GetById(culture, id),
                Products = products
            });
        }
    }
}
