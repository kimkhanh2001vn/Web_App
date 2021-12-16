using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopHouse.Admin.Models;
using ShopHouse.ApiIntegration;
using ShopHouse.Utilities.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHouse.Admin.Controllers.Components
{
    public class NavigationViewComponent : ViewComponent
    {
        public readonly ILanguageApiClient _languageApiClient;
        public NavigationViewComponent(ILanguageApiClient languageApiClient)
        {
            _languageApiClient = languageApiClient;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var language = await _languageApiClient.GetAll();
            var navigationVm = new NavigationViewModel()
            {
                CurrentLanguegaId = HttpContext.Session.GetString(SystemConstants.Appsettings.DefaultLangueId),
                languages = language.ResultObj
            };

            return View("Default", navigationVm);
        }
    }
}
