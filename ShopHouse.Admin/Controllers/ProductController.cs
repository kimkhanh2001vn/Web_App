using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using ShopHouse.ApiIntegration;
using ShopHouse.Utilities.Constants;
using ShopHouse.ViewModels.Catalog.Products;
using ShopHouse.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHouse.Admin.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductApiClient _productApiClient;
        private readonly ICategoryApiClient _categoryApiClient;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor  _httpContextAccessor;

        public ProductController(IProductApiClient productApiClient, 
            IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor, 
            ICategoryApiClient categoryApiClient)
        {
            _productApiClient = productApiClient;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _categoryApiClient = categoryApiClient;
        }

        public async Task<IActionResult> Index(string keyword,int? categoryId, int pageIndex = 1, int pageSize = 10)
        {
            //var session = HttpContext.Session.GetString("Token");
            var languageId = _httpContextAccessor.HttpContext.Session.GetString(SystemConstants.Appsettings.DefaultLangueId);
            var request = new GetManageProductPagingRequest()
            {
                keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize,
                LanguageId = languageId,
                CategoryId = categoryId
            };
            var data = await _productApiClient.GetPagings(request);
            if (TempData["result"] != null)
            {
                ViewBag.successMsg = TempData["result"];
            }
            ViewBag.keyword = keyword;
            var categories = await _categoryApiClient.GetAll(languageId);
            ViewBag.categories = categories.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.ID.ToString(),
                Selected = categoryId.HasValue && categoryId.Value == x.ID
            });
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create([FromForm]ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }
            var product = await _productApiClient.CreateProduct(request);
            if (product)
            {
                TempData["success"] = "Thêm sản phẩm thành công.";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Thêm sản phẩm không thành công.");
            return View(request);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var languageId = _httpContextAccessor.HttpContext.Session.GetString(SystemConstants.Appsettings.DefaultLangueId);
            var product = await _productApiClient.GetById(id, languageId);
            var edit = new ProductUpdateRequest()
            {
                Id = product.Id,
                Description = product.Description,
                Details = product.Details,
                Name = product.Name,
                SeoAlias = product.SeoAlias,
                SeoDescription = product.SeoDescription,
                SeoTitle = product.SeoTitle
            };
            return View(edit);
        }
        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Edit([FromForm] ProductUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }
            var product = await _productApiClient.UpdateProduct(request);
            if (product)
            {
                TempData["success"] = "Cập nhật sản phẩm thành công.";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Cập nhật sản phẩm không thành công.");
            return View(request);
        }
        [HttpGet]
        public async Task<IActionResult> CategoryAssign(int id)
        {
            var roleAssignRequest = await GetCategoryAssignRequest(id);
            return View(roleAssignRequest);
        }
        [HttpPost]
        public async Task<IActionResult> CategoryAssign(CategoryAssignRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var result = await _productApiClient.CategoryAssign(request.Id, request);

            if (result.IsSuccessed)
            {
                TempData["result"] = "Cập nhật danh mục thành công.";
                return RedirectToAction("Index", "Product");
            }
            var roleAssignRequest = await GetCategoryAssignRequest(request.Id);
            ModelState.AddModelError("", result.Message);
            return View(roleAssignRequest);
        }
        private async Task<CategoryAssignRequest> GetCategoryAssignRequest(int id)
        {
            var languageId = _httpContextAccessor.HttpContext.Session.GetString(SystemConstants.Appsettings.DefaultLangueId);
            var productObj = await _productApiClient.GetById(id,languageId);
            var categoriesObj = await _categoryApiClient.GetAll(languageId);
            var categoryRequest = new CategoryAssignRequest();
            foreach (var item in categoriesObj)
            {
                categoryRequest.Categories.Add(new SelectItem()
                {
                    ID = item.ID.ToString(),
                    Name = item.Name,
                    Selected = productObj.categories.Contains(item.Name)
                });
            }
            return categoryRequest;
        }
    }
}
