﻿using Microsoft.AspNetCore.Mvc;
using ShopHouse.ApiIntegration;
using System.Globalization;
using System.Threading.Tasks;

namespace ShopHouse.WebApp.Controllers.Components
{
    public class SideBarLeftViewComponent : ViewComponent
    {
        private readonly ICategoryApiClient _categoryApiClient;

        public SideBarLeftViewComponent(ICategoryApiClient categoryApiClient)
        {
            _categoryApiClient = categoryApiClient;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await _categoryApiClient.GetAll(CultureInfo.CurrentCulture.Name);
            return View(items);
        }
    }
}