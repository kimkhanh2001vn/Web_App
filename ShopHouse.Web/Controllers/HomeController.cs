using LazZiya.ExpressLocalization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopHouse.ApiIntegration;
using ShopHouse.Utilities.Constants;
using ShopHouse.ViewModels.Catalog.Categories;
using ShopHouse.ViewModels.Catalog.Products;
using ShopHouse.ViewModels.Common;
using ShopHouse.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHouse.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        // To localize backend strings inject SahredCultureLocalizer
        private readonly ISharedCultureLocalizer _loc;
        private readonly ISlideApiClient _slideApiClient;
        private readonly IProductApiClient _productApiClient;
        private readonly ICategoryApiClient _categoryApiClient;
        public HomeController(ILogger<HomeController> logger,
            ISharedCultureLocalizer loc,
            ISlideApiClient slideApiClient,
            IProductApiClient productApiClient,
            ICategoryApiClient categoryApiClient)
        {
            _logger = logger;
            _loc = loc;
            _slideApiClient = slideApiClient;
            _productApiClient = productApiClient;
            _categoryApiClient = categoryApiClient;
        }

        public async Task<IActionResult> Index()
        {
            var culture = CultureInfo.CurrentCulture.Name;
            //var msg = _loc.GetLocalizedString("Vietnamese");
            var viewmodel = new HomeViewModel
            {
                slides = await _slideApiClient.GetAll(),
                Featureproducts = await _productApiClient.GetfeaturedProducts(culture, SystemConstants.Productsettings.NumberOffFeaturedProduct),
                Popularproducts = await _productApiClient.GetfeaturedProducts(culture, SystemConstants.Productsettings.NumberOffPopularproduct)
            };
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult SetCultureCookie(string cltr, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(cltr)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
                );

            return LocalRedirect(returnUrl);
        }

    }
}
