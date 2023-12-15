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
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ShopHouse.Web.Controllers
{
    public class HomeController : Controller
    {
        #region Call Service
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
        #endregion
        #region Constant Value
        private string culture = CultureInfo.CurrentCulture.Name;
        #endregion
        public async Task<IActionResult> Index()
        {
            var product = await _productApiClient.GetAll(culture);

            List<ProductVm> products = await GetNewProducts();
            //var msg = _loc.GetLocalizedString("Vietnamese");

            return View(new HomeViewModel()
            {
                Newproducts = products.Where(x => x.DateCreated.Year.Equals(DateTime.Now.Year)).ToList(),
            });
        }
        #region GET DATA
        private async Task<List<ProductVm>> GetNewProducts()
        {
            List<ProductVm> productVms = await _productApiClient.GetAll(culture);

            productVms.OrderByDescending(x => x.DateCreated).Take(9).ToList();

            return productVms;
        }
        #endregion
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Collections()
        {
            return View();
        }
        public IActionResult ComingSoon()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult FAQs()
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
