using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopHouse.Application.Catalog.Products;
using ShopHouse.ViewModels.Catalog.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHouse.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        //https://locahost:port/product
        //[HttpGet("{languageId}")]
        //public async Task<IActionResult> Get(string languageId)
        //{
        //    var products = await _productService.GetAll(languageId);
        //    return Ok(products); 
        //}
        //https://locahost:port/product
        [HttpGet("paging")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllPaging([FromQuery]GetManageProductPagingRequest request)
        {
            var products = await _productService.GetAllPaging(request);
            return Ok(products);
        }
        //[HttpGet("{languageId}")]
        //public async Task<IActionResult> GetAllByCategoryId(string languageId,[FromQuery] GetPublicProductPagingRequest request)
        //{
        //    var products = await _productService.GetAllByCategoryId(request);
        //    return Ok(products);
        //}
        //https://locahost:port/product/1
        [HttpGet("{id}/{languageId}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(int id, string languageId)
        {
            var product = await _productService.GetById(id, languageId);
            if(product == null)
            {
                return BadRequest("cannot find product");
            }
            return Ok(product);
        }
        [HttpPut("{id}/categories")]
        public async Task<IActionResult> CategoryAssign(int id,[FromBody] CategoryAssignRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _productService.CategoryAssign(id,request);
            if (!result.IsSuccessed)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }
        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create([FromForm] ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var productId = await _productService.Create(request);
            if (productId == 0)
                return BadRequest();

            var product = await _productService.GetById(productId, request.LanguageId);
            return CreatedAtAction(nameof(GetById), new { id = productId }, product);  
        }
        [HttpPut("{productId}")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Update([FromRoute]int productId, [FromForm] ProductUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            request.Id = productId;
            var affectedResult = await _productService.Update(request);
            if (affectedResult == 0)
            {
                return BadRequest();
            }
            return Ok();
        }
        //https://locahost:port/product/1
        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(int productId)
        {
            var affectedResult = await _productService.Delete(productId);
            if (affectedResult == 0)
            {
                return BadRequest();
            }
            return Ok();
        }
        [HttpPut("price/{id}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice([FromForm]int id, decimal newPrice)
        {
            var isSuccessful = await _productService.UpdatePrice(id,newPrice);
            if (isSuccessful)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet("featured/{languageId}/{take}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetfeaturedProducts(string languageId, int take)
        {
            var products = await _productService.GetfeaturedProducts(languageId, take);
            return Ok(products);
        }
        [HttpGet("popular/{languageId}/{take}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetpopularProducts(string languageId, int take)
        {
            var products = await _productService.GetpopularProducts(languageId, take);
            return Ok(products);
        }
    }
}
