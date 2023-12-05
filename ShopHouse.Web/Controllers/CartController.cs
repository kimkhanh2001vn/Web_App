using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopHouse.ApiIntegration;
using ShopHouse.Data.Entities;
using ShopHouse.Utilities.Constants;
using ShopHouse.ViewModels.Sales;
using ShopHouse.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHouse.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        private readonly IOrderApiClient _orderApiClient;
        public CartController(IProductApiClient productApiClient, IOrderApiClient orderApiClient)
        {
            _productApiClient = productApiClient;
            _orderApiClient = orderApiClient;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        //public IActionResult CheckOut()
        //{
        //    return View(GetCheckOutViewMode());
        //}
        //[HttpPost]
        //public async Task<IActionResult> CheckOut(CheckOutViewModel request)
        //{
        //    var model = GetCheckOutViewMode();
        //    var orderDetail = new List<OrderDetailVm>();
        //    foreach (var item in model.cartItems)
        //    {
        //        orderDetail.Add(new OrderDetailVm()
        //        {
        //            ProductId = item.ProductId,
        //            Quantity = item.Quantity
        //        });
        //    }
        //    var checkoutRequest = new CheckOutRequest()
        //    {
        //        Address = request.checkOut.Address,
        //        Email = request.checkOut.Email,
        //        Name = request.checkOut.Name,
        //        PhoneNumber = request.checkOut.PhoneNumber
        //    };
        //    //TODO:Add to API
        //    //var orders = await _orderApiClient.CreateOrder(request.checkOut);
        //    //if (orders != null)
        //    //{
        //    //    return Redirect("");
        //    //}
        //    TempData["SuccessMsg"] = "Order puschased successful";
        //    return View(model);
        //}
        [HttpGet]
        public IActionResult GetListItems()
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if (session != null)
            {
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
            }
            return Ok(currentCart);
        }
        [HttpPost]
        public async Task<IActionResult> AddToCart(int id, string languageId)
        {
            var product = await _productApiClient.GetById(id, languageId);
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if (session != null)
            {
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);

                if (currentCart.Exists(x => x.ProductId == id))
                {
                    foreach (var item in currentCart)
                    {
                        if (item.ProductId == id)
                        {
                            item.Quantity += 1;
                        }
                    }
                }
                else
                {
                    var cartItem = new CartItemViewModel()
                    {
                        ProductId = id,
                        Description = product.Description,
                        Images = product.ThumbnailImage,
                        Name = product.Name,
                        Quantity = 1,
                        Price = product.Price
                    };
                    currentCart.Add(cartItem);
                }

                HttpContext.Session.SetString(SystemConstants.CartSession, JsonConvert.SerializeObject(currentCart));
            }
            else
            {
                var cartItem = new CartItemViewModel()
                {
                    ProductId = id,
                    Description = product.Description,
                    Images = product.ThumbnailImage,
                    Name = product.Name,
                    Quantity = 1,
                    Price = product.Price
                };

                var list = new List<CartItemViewModel>();
                list.Add(cartItem);

                HttpContext.Session.SetString(SystemConstants.CartSession, JsonConvert.SerializeObject(list));
            }

            //int quantity = 1;
            //if (currentCart.Any(x => x.ProductId == id))
            //{
            //    quantity = currentCart.First(x => x.ProductId == id).Quantity + 1;
            //}

            //var cartItem = new CartItemViewModel()
            //{
            //    ProductId = id,
            //    Description = product.Description,
            //    Images = product.ThumbnailImage,
            //    Name = product.Name,
            //    Quantity = quantity,
            //    Price = product.Price
            //};

            //currentCart.Add(cartItem);
            //HttpContext.Session.SetString(SystemConstants.CartSession, JsonConvert.SerializeObject(currentCart));
            return View();
        }
        public IActionResult UpdateCart(int id, int quantity)
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if (session != null)
            {
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
            }

            foreach (var item in currentCart)
            {
                if (item.ProductId == id)
                {
                    if (quantity == 0)
                    {
                        currentCart.Remove(item);
                        break;
                    }
                    item.Quantity = quantity;
                }
            }
            HttpContext.Session.SetString(SystemConstants.CartSession, JsonConvert.SerializeObject(currentCart));
            return Ok(currentCart);
        }
        //private CheckOutViewModel GetCheckOutViewMode()
        //{
        //    var session = HttpContext.Session.GetString(SystemConstants.CartSession);
        //    List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
        //    if (session != null)
        //    {
        //        currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
        //    }
        //    var checkoutVm = new CheckOutViewModel()
        //    {
        //        cartItems = currentCart,
        //        checkOut = new CheckOutRequest()
        //    };
        //    return checkoutVm;
        //}
    }
}
